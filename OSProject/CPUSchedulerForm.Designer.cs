namespace OSProject
{
    partial class CpuSchedulerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ScheduleBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ProcessDuration = new System.Windows.Forms.NumericUpDown();
            this.ProcessDurationLabel = new System.Windows.Forms.Label();
            this.ProcessPriority = new System.Windows.Forms.NumericUpDown();
            this.ProcessPriorityLabel = new System.Windows.Forms.Label();
            this.ProcessComingTime = new System.Windows.Forms.NumericUpDown();
            this.ProcessComingTimeLabel = new System.Windows.Forms.Label();
            this.AddProcessBtn = new System.Windows.Forms.Button();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ParentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoundRobinTimeQuanta = new System.Windows.Forms.NumericUpDown();
            this.RoundRobinTimeQuantaLabel = new System.Windows.Forms.Label();
            this.AverageWaitingTimeLabel = new System.Windows.Forms.Label();
            this.AverageWaitingTimeValue = new System.Windows.Forms.Label();
            this.ProcessGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessComingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.ParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoundRobinTimeQuanta)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.Items.AddRange(new object[] {
            "FCFS",
            "SJF (Preemptive)",
            "SJF (Non-Preemptive)",
            "Priority (Preemptive)",
            "Priority (Non-Preemptive)",
            "Round Robin"});
            this.TypeComboBox.Location = new System.Drawing.Point(233, 65);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(228, 37);
            this.TypeComboBox.TabIndex = 0;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(10, 68);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(210, 29);
            this.TypeLabel.TabIndex = 1;
            this.TypeLabel.Text = "Type of Scheduler";
            // 
            // ProcessGroupBox
            // 
            this.ProcessGroupBox.Controls.Add(this.DataGridView);
            this.ProcessGroupBox.Location = new System.Drawing.Point(9, 112);
            this.ProcessGroupBox.Name = "ProcessGroupBox";
            this.ProcessGroupBox.Size = new System.Drawing.Size(475, 454);
            this.ProcessGroupBox.TabIndex = 3;
            this.ProcessGroupBox.TabStop = false;
            this.ProcessGroupBox.Text = "Processes";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowDrop = true;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DataGridView.Location = new System.Drawing.Point(6, 33);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(463, 415);
            this.DataGridView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brought to you by: Omar Taher Saad - Mayar Gamal - Mayar Sayed - Sara Safwat";
            // 
            // ScheduleBtn
            // 
            this.ScheduleBtn.Location = new System.Drawing.Point(267, 572);
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.Size = new System.Drawing.Size(150, 56);
            this.ScheduleBtn.TabIndex = 5;
            this.ScheduleBtn.Text = "Schedule";
            this.ScheduleBtn.UseVisualStyleBackColor = true;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(53, 572);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(150, 56);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ProcessDuration
            // 
            this.ProcessDuration.Location = new System.Drawing.Point(603, 67);
            this.ProcessDuration.Name = "ProcessDuration";
            this.ProcessDuration.Size = new System.Drawing.Size(120, 34);
            this.ProcessDuration.TabIndex = 1;
            // 
            // ProcessDurationLabel
            // 
            this.ProcessDurationLabel.Location = new System.Drawing.Point(480, 54);
            this.ProcessDurationLabel.Name = "ProcessDurationLabel";
            this.ProcessDurationLabel.Size = new System.Drawing.Size(117, 59);
            this.ProcessDurationLabel.TabIndex = 7;
            this.ProcessDurationLabel.Text = "Process Duration";
            // 
            // ProcessPriority
            // 
            this.ProcessPriority.Location = new System.Drawing.Point(1110, 68);
            this.ProcessPriority.Name = "ProcessPriority";
            this.ProcessPriority.Size = new System.Drawing.Size(90, 34);
            this.ProcessPriority.TabIndex = 3;
            this.ProcessPriority.Visible = false;
            // 
            // ProcessPriorityLabel
            // 
            this.ProcessPriorityLabel.Location = new System.Drawing.Point(997, 54);
            this.ProcessPriorityLabel.Name = "ProcessPriorityLabel";
            this.ProcessPriorityLabel.Size = new System.Drawing.Size(107, 59);
            this.ProcessPriorityLabel.TabIndex = 7;
            this.ProcessPriorityLabel.Text = "Process Priority";
            this.ProcessPriorityLabel.Visible = false;
            // 
            // ProcessComingTime
            // 
            this.ProcessComingTime.Location = new System.Drawing.Point(861, 68);
            this.ProcessComingTime.Name = "ProcessComingTime";
            this.ProcessComingTime.Size = new System.Drawing.Size(120, 34);
            this.ProcessComingTime.TabIndex = 2;
            // 
            // ProcessComingTimeLabel
            // 
            this.ProcessComingTimeLabel.Location = new System.Drawing.Point(748, 54);
            this.ProcessComingTimeLabel.Name = "ProcessComingTimeLabel";
            this.ProcessComingTimeLabel.Size = new System.Drawing.Size(107, 59);
            this.ProcessComingTimeLabel.TabIndex = 7;
            this.ProcessComingTimeLabel.Text = "Process Coming Time";
            // 
            // AddProcessBtn
            // 
            this.AddProcessBtn.Enabled = false;
            this.AddProcessBtn.Location = new System.Drawing.Point(494, 123);
            this.AddProcessBtn.Name = "AddProcessBtn";
            this.AddProcessBtn.Size = new System.Drawing.Size(162, 41);
            this.AddProcessBtn.TabIndex = 4;
            this.AddProcessBtn.Text = "Add Process";
            this.AddProcessBtn.UseVisualStyleBackColor = true;
            this.AddProcessBtn.Click += new System.EventHandler(this.AddProcessBtn_Click);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(OSProject.Program);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // ParentPanel
            // 
            this.ParentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentPanel.AutoScroll = true;
            this.ParentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ParentPanel.Controls.Add(this.panel1);
            this.ParentPanel.Location = new System.Drawing.Point(490, 174);
            this.ParentPanel.Margin = new System.Windows.Forms.Padding(10);
            this.ParentPanel.Name = "ParentPanel";
            this.ParentPanel.Size = new System.Drawing.Size(710, 392);
            this.ParentPanel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 369);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RoundRobinTimeQuanta
            // 
            this.RoundRobinTimeQuanta.Location = new System.Drawing.Point(1110, 127);
            this.RoundRobinTimeQuanta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoundRobinTimeQuanta.Name = "RoundRobinTimeQuanta";
            this.RoundRobinTimeQuanta.Size = new System.Drawing.Size(90, 34);
            this.RoundRobinTimeQuanta.TabIndex = 3;
            this.RoundRobinTimeQuanta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RoundRobinTimeQuanta.Visible = false;
            this.RoundRobinTimeQuanta.ValueChanged += new System.EventHandler(this.RoundRobinTimeQuanta_ValueChanged);
            // 
            // RoundRobinTimeQuantaLabel
            // 
            this.RoundRobinTimeQuantaLabel.Location = new System.Drawing.Point(900, 129);
            this.RoundRobinTimeQuantaLabel.Name = "RoundRobinTimeQuantaLabel";
            this.RoundRobinTimeQuantaLabel.Size = new System.Drawing.Size(204, 26);
            this.RoundRobinTimeQuantaLabel.TabIndex = 7;
            this.RoundRobinTimeQuantaLabel.Text = "RR Time Quanta";
            this.RoundRobinTimeQuantaLabel.Visible = false;
            // 
            // AverageWaitingTimeLabel
            // 
            this.AverageWaitingTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AverageWaitingTimeLabel.AutoSize = true;
            this.AverageWaitingTimeLabel.Location = new System.Drawing.Point(766, 586);
            this.AverageWaitingTimeLabel.Name = "AverageWaitingTimeLabel";
            this.AverageWaitingTimeLabel.Size = new System.Drawing.Size(250, 29);
            this.AverageWaitingTimeLabel.TabIndex = 10;
            this.AverageWaitingTimeLabel.Text = "Average Waiting Time";
            // 
            // AverageWaitingTimeValue
            // 
            this.AverageWaitingTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AverageWaitingTimeValue.AutoSize = true;
            this.AverageWaitingTimeValue.ForeColor = System.Drawing.Color.Red;
            this.AverageWaitingTimeValue.Location = new System.Drawing.Point(1018, 586);
            this.AverageWaitingTimeValue.Name = "AverageWaitingTimeValue";
            this.AverageWaitingTimeValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AverageWaitingTimeValue.Size = new System.Drawing.Size(142, 29);
            this.AverageWaitingTimeValue.TabIndex = 11;
            this.AverageWaitingTimeValue.Text = "(Not set yet)";
            // 
            // CpuSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 667);
            this.Controls.Add(this.AverageWaitingTimeValue);
            this.Controls.Add(this.AverageWaitingTimeLabel);
            this.Controls.Add(this.ParentPanel);
            this.Controls.Add(this.AddProcessBtn);
            this.Controls.Add(this.ProcessComingTimeLabel);
            this.Controls.Add(this.ProcessComingTime);
            this.Controls.Add(this.RoundRobinTimeQuantaLabel);
            this.Controls.Add(this.RoundRobinTimeQuanta);
            this.Controls.Add(this.ProcessPriorityLabel);
            this.Controls.Add(this.ProcessPriority);
            this.Controls.Add(this.ProcessDurationLabel);
            this.Controls.Add(this.ProcessDuration);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ScheduleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessGroupBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CpuSchedulerForm";
            this.Padding = new System.Windows.Forms.Padding(35, 109, 35, 36);
            this.Text = "CPU Scheduler (G46)";
            this.ProcessGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessComingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ParentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoundRobinTimeQuanta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.GroupBox ProcessGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ScheduleBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.NumericUpDown ProcessDuration;
        private System.Windows.Forms.Label ProcessDurationLabel;
        private System.Windows.Forms.NumericUpDown ProcessPriority;
        private System.Windows.Forms.Label ProcessPriorityLabel;
        private System.Windows.Forms.NumericUpDown ProcessComingTime;
        private System.Windows.Forms.Label ProcessComingTimeLabel;
        private System.Windows.Forms.Button AddProcessBtn;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Panel ParentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown RoundRobinTimeQuanta;
        private System.Windows.Forms.Label RoundRobinTimeQuantaLabel;
        private System.Windows.Forms.Label AverageWaitingTimeLabel;
        private System.Windows.Forms.Label AverageWaitingTimeValue;
    }
}

