using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public CPUSchedulerForm()
        {
            InitializeComponent();
            Processes = new List<Process>();
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
        }

        private static void FCFS()
        {

        }

        private static void SJF(bool isPreemptive = true)
        {

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
            
        }
    }
}
