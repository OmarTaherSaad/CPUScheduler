using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace OSProject
{
    public partial class CpuSchedulerForm : MetroForm
    {
        public List<Process> Processes;
        public Timeline CpuTimeline;

        public CpuSchedulerForm()
        {
            InitializeComponent();

            Processes = new List<Process>();
            CpuTimeline = new Timeline();

            Processes.Add(new Process(0, 2, 1));
            Processes.Add(new Process(1, 4, 2));
            Processes.Add(new Process(4, 2, 1));
            Processes.Add(new Process(5, 9, 0));
            Processes.Add(new Process(12, 2, 1));

            RefreshGridView();
            ReInitializeProcesses();
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Enable Process Appending
            if (!AddProcessBtn.Enabled)
            {
                AddProcessBtn.Enabled = true;
            }

            //Renable Schedule button
            if (!ScheduleBtn.Enabled)
            {
                ScheduleBtn.Enabled = true;
                ScheduleBtn.Text = @"Schedule";
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
                if (DataGridView != null && DataGridView.Columns.Count > 0)
                {
                    DataGridView.Columns["Priority"].Visible = false;
                }
            }
            else
            {
                ProcessPriority.Show();
                ProcessPriorityLabel.Show();
                if (DataGridView != null && DataGridView.Columns.Count > 0)
                {
                    DataGridView.Columns["Priority"].Visible = true;
                }
            }
            //Hide RR time quanta input & label if selected schedule is not Round Robin
            if (TypeComboBox.SelectedIndex != 5)
            {
                RoundRobinTimeQuanta.Hide();
                RoundRobinTimeQuantaLabel.Hide();
            }
            else
            {
                RoundRobinTimeQuanta.Show();
                RoundRobinTimeQuantaLabel.Show();
            }


        }

        private void FCFS()
        {
            var sortedProcesses = Processes.OrderBy(p => p.ComingTime).ToList();
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

        private void SJF(bool isPreemptive = true)
        {
            var sortedProcesses = Processes.OrderBy(p => p.ComingTime).ThenBy(p => p.Duration).ToList();
            int timer = sortedProcesses.First().ComingTime;

            if (isPreemptive) //Preemptive
            {
                while (sortedProcesses.Count(p => !p.Finished) > 0)
                {
                    //Get arrived processes and sort them by duration
                    var nextProcess = sortedProcesses.Where(p => p.ComingTime <= timer && !p.Finished).OrderBy(p => p.RemainingTime).FirstOrDefault();
                    while (nextProcess is null)
                    {
                        timer++;
                        nextProcess = sortedProcesses.FirstOrDefault(p => p.ComingTime <= timer && !p.Finished);
                    }
                    //Execute first shortest one
                    //Time to next coming process
                    var executionTime = nextProcess.Duration;
                    if (sortedProcesses.IndexOf(nextProcess) < sortedProcesses.Count() - 1)
                    {
                        Process first = null;
                        foreach (var process in sortedProcesses.Where(p => p.ComingTime > nextProcess.ComingTime && !p.Finished).OrderBy(p => p.ComingTime).ThenBy(p => p.RemainingTime))
                        {
                            first = process;
                            break;
                        }

                        if (first != null)
                        {
                            executionTime = first.ComingTime - timer;
                            if (executionTime == 0)
                            {
                                executionTime = nextProcess.RemainingTime;
                            }
                        }
                        if (executionTime > nextProcess.RemainingTime)
                        {
                            executionTime = nextProcess.RemainingTime;
                        }
                    }

                    if (nextProcess == CpuTimeline.Executes.LastOrDefault().Process)
                    {
                        //Same Process
                        var executed = CpuTimeline.Executes.Last().Duration;
                        var startTime = CpuTimeline.Executes.Last().StartTime;
                        CpuTimeline.Executes.Remove(CpuTimeline.Executes.Last());
                        CpuTimeline.AddExecution(startTime, timer + executionTime, nextProcess);
                    }
                    else
                    {
                        CpuTimeline.AddExecution(timer, timer + executionTime, nextProcess);
                    }
                    nextProcess.ExecutedTime += executionTime;
                    timer += executionTime;
                }
            }
            else //Non Preemptive
            {
                while (sortedProcesses.Count(p => !p.Finished) > 0)
                {
                    //Get arrived processes and sort them by duration
                    var nextProcess = sortedProcesses.Where(p => p.ComingTime <= timer && !p.Finished).OrderBy(p => p.Duration).FirstOrDefault();
                    while (nextProcess is null)
                    {
                        timer++;
                        nextProcess = sortedProcesses.FirstOrDefault(p => p.ComingTime <= timer && !p.Finished);
                    }
                    //Execute first shortest one

                    CpuTimeline.AddExecution(timer, timer + nextProcess.Duration, nextProcess);
                    nextProcess.ExecutedTime = nextProcess.Duration;
                    timer += nextProcess.Duration;
                }
            }
        }

        private void Priority(bool isPreemptive = true)
        {
            var sortedProcesses = Processes.OrderBy(p => p.ComingTime).ThenBy(p => p.Priority).ToList();
            int timer = sortedProcesses.First().ComingTime;

            if (isPreemptive) //Preemptive
            {
                while (sortedProcesses.Count(p => !p.Finished) > 0)
                {
                    //Get arrived processes and sort them by priority
                    var nextProcess = sortedProcesses.Where(p => p.ComingTime <= timer && !p.Finished).OrderBy(p => p.Priority).FirstOrDefault();
                    while (nextProcess is null)
                    {
                        timer++;
                        nextProcess = sortedProcesses.FirstOrDefault(p => p.ComingTime <= timer && !p.Finished);
                    }
                    //Execute first high-priority one
                    //Time to next coming process
                    var executionTime = nextProcess.Duration;
                    if (sortedProcesses.IndexOf(nextProcess) < sortedProcesses.Count() - 1)
                    {
                        Process first = null;
                        foreach (var process in sortedProcesses.Where(p => p.ComingTime > nextProcess.ComingTime && !p.Finished).OrderBy(p => p.ComingTime).ThenBy(p => p.Priority))
                        {
                            first = process;
                            break;
                        }

                        if (first != null)
                        {
                            executionTime = first.ComingTime - timer;
                            if (executionTime == 0)
                            {
                                executionTime = nextProcess.RemainingTime;
                            }
                        }
                        if (executionTime > nextProcess.RemainingTime)
                        {
                            executionTime = nextProcess.RemainingTime;
                        }
                    }

                    if (nextProcess == CpuTimeline.Executes.LastOrDefault().Process)
                    {
                        //Same Process
                        var executed = CpuTimeline.Executes.Last().Duration;
                        var startTime = CpuTimeline.Executes.Last().StartTime;
                        CpuTimeline.Executes.Remove(CpuTimeline.Executes.Last());
                        CpuTimeline.AddExecution(startTime, timer + executionTime, nextProcess);
                    }
                    else
                    {
                        CpuTimeline.AddExecution(timer, timer + executionTime, nextProcess);
                    }
                    nextProcess.ExecutedTime += executionTime;
                    timer += executionTime;
                }
            }
            else //Non Preemptive
            {
                while (sortedProcesses.Count(p => !p.Finished) > 0)
                {
                    //Get arrived processes and sort them by priority
                    var nextProcess = sortedProcesses.Where(p => p.ComingTime <= timer && !p.Finished).OrderBy(p => p.Priority).FirstOrDefault();
                    while (nextProcess is null)
                    {
                        timer++;
                        nextProcess = sortedProcesses.FirstOrDefault(p => p.ComingTime <= timer && !p.Finished);
                    }
                    //Execute first high-priority one

                    CpuTimeline.AddExecution(timer, timer + nextProcess.Duration, nextProcess);
                    nextProcess.ExecutedTime = nextProcess.Duration;
                    timer += nextProcess.Duration;
                }
            }
        }

        private void RoundRobin()
        {
            int quanta = (int)RoundRobinTimeQuanta.Value;
            var sortedProcesses = Processes.OrderBy(p => p.ComingTime).ToList();
            int timer = sortedProcesses.First().ComingTime;

            while (sortedProcesses.Count(p => !p.Finished) > 0)
            {
                //Get arrived processes and sort them by coming time
                var nextProcess = sortedProcesses.Where(p => p.ComingTime <= timer && !p.Finished).OrderBy(p => p.ComingTime).FirstOrDefault();
                while (nextProcess is null)
                {
                    timer++;
                    nextProcess = sortedProcesses.FirstOrDefault(p => p.ComingTime <= timer && !p.Finished);
                }
                //Time to really execute
                var executionTime = nextProcess.RemainingTime;
                if (executionTime > quanta)
                {
                    executionTime = quanta;
                }
                CpuTimeline.AddExecution(timer, timer + executionTime, nextProcess);
                nextProcess.ExecutedTime += executionTime;
                timer += quanta;
            }
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
            //Reinitialize Processes
            ReInitializeProcesses();

            RefreshGridView();

            //Renable Schedule button
            if (!ScheduleBtn.Enabled)
            {
                ScheduleBtn.Enabled = true;
                ScheduleBtn.Text = @"Schedule";
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Processes.Clear();
            CpuTimeline.Executes.Clear();
            panel1.Invalidate();
            RefreshGridView();
            
        }

        private void RefreshGridView()
        {
            DataGridView.DataSource = null;
            DataGridView.DataSource = Processes;
            DataGridView.Refresh();
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            ScheduleBtn.Text = @"Scheduling..";
            ScheduleBtn.Enabled = false;
            AverageWaitingTimeValue.Text = @"(Not Set Yet)";
            //Check existence of processes
            if (!Processes.Any())
            {
                MessageBox.Show(@"You cannot schedule ZERO processes!", @"Please, enter any processes.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Check that scheduling type selected
            if (TypeComboBox.SelectedIndex < 0)
            {
                MessageBox.Show(@"You cannot schedule using NO Scheduler type!", @"Please, choose any scheduler type.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Reinitialize Processes
            ReInitializeProcesses();
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
            DrawTimeline(true);
            ScheduleBtn.Text = @"Scheduled";
            AverageWaitingTimeValue.Text = GetAverageWaitingTime() + @" seconds";
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //Save Image
            Bitmap image = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(image, new Rectangle(0, 0, panel1.Width, panel1.Height));
            image.Save(@"C:\CPUScheduler\test.png",ImageFormat.Png);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawTimeline();
        }

        private void DrawTimeline(bool live = false)
        {
            if (!CpuTimeline.Executes.Any())
            {
                panel1.CreateGraphics().Clear(Color.White);
                return;
            }

            var p = panel1;
            var g = p.CreateGraphics();
            //Total time and mapping it to total width
            var totalTime = CpuTimeline.Executes.Last().EndTime;
            //var ratio = (p.Width - 5)/ totalTime;
            var ratio = 50;
            if (live)
            {
                p.Width = totalTime * ratio + 50;
                if (p.Width < ParentPanel.Width)
                {
                    p.Width = ParentPanel.Width;
                }
            }

            var h = (int)(p.Height * 0.05);

            g.Clear(Color.White);
            foreach (var executeInstance in CpuTimeline.Executes.OrderBy(ex => ex.StartTime))
            {
                var startPosition = 10 + executeInstance.StartTime * ratio;

                //Execution rectangle
                var rectangle = new Rectangle(startPosition, h, executeInstance.Duration * ratio, (int)(p.Height * 0.5));
                g.DrawRectangle(new Pen(Color.Black), rectangle);
                g.FillRectangle(new SolidBrush(Color.Red), rectangle);
                //Process Title
                g.DrawString("P" + Processes.IndexOf(executeInstance.Process), new Font(new FontFamily("Arial"), 16), new SolidBrush(Color.AliceBlue), startPosition, h);

                //Start time
                var separator = new Rectangle(startPosition, h, 1, (int)(p.Height * 0.5));

                var font = new Font(new FontFamily("Arial"), 14);
                var brush = new SolidBrush(Color.Black);
                g.DrawString("T" + executeInstance.StartTime, font, brush, startPosition - 10, (int)(p.Height * 0.7));
                g.FillRectangle(new SolidBrush(Color.Black), separator);

                //End time
                separator = new Rectangle(startPosition + executeInstance.Duration * ratio, h, 1, (int)(p.Height * 0.5));

                g.DrawString("T" + executeInstance.EndTime, font, brush, startPosition + executeInstance.Duration * ratio - 10, (int)(p.Height * 0.7));
                //g.DrawRectangle(new Pen(Color.Black), separator);
                g.FillRectangle(new SolidBrush(Color.Black), separator);

                if (live)
                {
                    RefreshGridView();
                    System.Threading.Thread.Sleep(700);
                }
            }
            RefreshGridView();
        }

        private void ReInitializeProcesses()
        {
            foreach (var process in Processes)
            {
                process.ExecutedTime = 0;
            }
            CpuTimeline.Executes.Clear();
        }

        private void RoundRobinTimeQuanta_ValueChanged(object sender, EventArgs e)
        {
            //Renable Schedule button
            if (!ScheduleBtn.Enabled)
            {
                ScheduleBtn.Enabled = true;
                ScheduleBtn.Text = @"Schedule";
            }
        }

        private float GetAverageWaitingTime()
        {
            float awt = 0; //Average Waiting Time
            foreach (var process in Processes)
            {
                awt += CpuTimeline.Executes.FirstOrDefault(ex => ex.Process == process).StartTime - process.ComingTime;
            }
            return awt/Processes.Count;
        }
    }
}
