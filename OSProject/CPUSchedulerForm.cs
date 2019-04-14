using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace OSProject
{
    public partial class CPUSchedulerForm : MetroForm
    {
        public List<Process> Processes;
        public Timeline CpuTimeline;

        public CPUSchedulerForm()
        {
            InitializeComponent();

            Processes = new List<Process>();
            CpuTimeline = new Timeline();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Enable Process Appending
            if (!AddProcessBtn.Enabled)
            {
                AddProcessBtn.Enabled = true;
            }
            //Scheduler Type selected
            /*
               0-FCFS
               1-SJF (Preemptive)
               2-SJF (Non-Preemptive)
               3-Priority (Preemptive)
               4-Priority (Non-Preemptive)
               5-Round Robin
             */
            //Hide Priority input & label if selected schedule is not priority
            if (TypeComboBox.SelectedIndex != 3 && TypeComboBox.SelectedIndex != 4)
            {
                ProcessPriority.Value = 0;
                ProcessPriority.Hide();
                ProcessPriorityLabel.Hide();
            }
            else
            {
                ProcessPriority.Show();
                ProcessPriorityLabel.Show();
            }
            
        }

        private static void FCFS()
        {

        }

        private void SJF(bool isPreemptive = true)
        {
            //Non Preemptive
            var sortedProcesses = Processes.OrderBy(p => p.ComingTime).ThenBy(p => p.Duration).ToList();
            int timer = sortedProcesses.First().ComingTime;
            foreach (var process in sortedProcesses)
            {
                if (timer < process.ComingTime)
                {
                    timer = process.ComingTime;
                }
                CpuTimeline.AddExecution(timer, timer + process.Duration, process);
                process.ExecutedTime = process.Duration;
                timer += process.Duration;
            }
        }
        private static void Priority(bool isPreemptive = true)
        {

        }

        private static void RoundRobin()
        {

        }

        private void ProcessCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddProcessBtn_Click(object sender, EventArgs e)
        {
            Processes.Add(
                new Process(
                    (int)ProcessComingTime.Value,
                    (int)ProcessDuration.Value,
                    (int)ProcessPriority.Value
                    )
                );
            RefreshGridView();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Processes.Clear();
            RefreshGridView();
            
        }

        private void RefreshGridView()
        {
            DataGridView.DataSource = null;
            DataGridView.DataSource = Processes;
            DataGridView.Refresh();
        }

        private void DrawGantt()
        {
            var p = panel1;
            var g = p.CreateGraphics();
            //Total time and mapping it to total width
            int totalTime = CpuTimeline.Executes.Last().EndTime;
            var ratio = p.Width / totalTime;

            int h = (int) (p.Height * 0.15);
            int startPosition = 0;
            foreach (var executeInstance in CpuTimeline.Executes)
            {
                startPosition = executeInstance.StartTime* ratio;
                //Execution rectangle
                var rectangle = new Rectangle(startPosition,h , (int)(executeInstance.Duration * ratio), (int)(p.Height * 0.5));
                g.DrawRectangle(new Pen(Color.Black), rectangle);
                g.FillRectangle(new SolidBrush(Color.Red), rectangle);
                //Process Title
                g.DrawString("P"+Processes.IndexOf(executeInstance.Process),new Font(new FontFamily("Arial"), 16),new SolidBrush(Color.AliceBlue),startPosition,h);

                //Start time
                var Separator = new Rectangle(startPosition, h, 1, (int)(p.Height * 0.5));

                g.DrawString("T" + executeInstance.StartTime, new Font(new FontFamily("Arial"), 14), new SolidBrush(Color.Black), startPosition,(int)(p.Height*0.9));
                g.DrawRectangle(new Pen(Color.Black), Separator);
                g.FillRectangle(new SolidBrush(Color.Black), Separator);

                //End time
                Separator = new Rectangle(startPosition + executeInstance.Duration * ratio, h, 10, (int)(p.Height * 0.5));

                g.DrawString("T" + executeInstance.EndTime, new Font(new FontFamily("Arial"), 14), new SolidBrush(Color.Black), startPosition+executeInstance.Duration*ratio,(int)(p.Height*0.9));
                g.DrawRectangle(new Pen(Color.Black), Separator);
                g.FillRectangle(new SolidBrush(Color.Black), Separator);
            }
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            //Switching to start scheduling
            switch (TypeComboBox.SelectedIndex)
            {
                case 0: //FCFS
                    FCFS();
                    break;
                case 1: //SJF (Preemptive)
                    SJF();
                    break;

                case 2: //SJF (Non-Preemptive)
                    SJF(false);
                    break;
                case 3: //Priority (Preemptive)
                    Priority();
                    break;
                case 4: //Priority (Non-Preemptive)
                    Priority(false);
                    break;
                case 5: //Round Robin
                    RoundRobin();
                    break;
            }

            DrawGantt();
        }
    }
}
