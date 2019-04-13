namespace OSProject
{
    partial class CPUSchedulerForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProcessGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessComingTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(6, 33);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(463, 415);
            this.DataGridView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 643);
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
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(53, 572);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(150, 56);
            this.ResetBtn.TabIndex = 5;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ProcessDuration
            // 
            this.ProcessDuration.Location = new System.Drawing.Point(603, 67);
            this.ProcessDuration.Name = "ProcessDuration";
            this.ProcessDuration.Size = new System.Drawing.Size(120, 34);
            this.ProcessDuration.TabIndex = 6;
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
            this.ProcessPriority.TabIndex = 6;
            // 
            // ProcessPriorityLabel
            // 
            this.ProcessPriorityLabel.Location = new System.Drawing.Point(997, 54);
            this.ProcessPriorityLabel.Name = "ProcessPriorityLabel";
            this.ProcessPriorityLabel.Size = new System.Drawing.Size(107, 59);
            this.ProcessPriorityLabel.TabIndex = 7;
            this.ProcessPriorityLabel.Text = "Process Priority";
            // 
            // ProcessComingTime
            // 
            this.ProcessComingTime.Location = new System.Drawing.Point(861, 68);
            this.ProcessComingTime.Name = "ProcessComingTime";
            this.ProcessComingTime.Size = new System.Drawing.Size(120, 34);
            this.ProcessComingTime.TabIndex = 6;
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
            this.AddProcessBtn.Location = new System.Drawing.Point(770, 127);
            this.AddProcessBtn.Name = "AddProcessBtn";
            this.AddProcessBtn.Size = new System.Drawing.Size(162, 41);
            this.AddProcessBtn.TabIndex = 8;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(490, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CPUSchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddProcessBtn);
            this.Controls.Add(this.ProcessComingTimeLabel);
            this.Controls.Add(this.ProcessComingTime);
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
            this.Name = "CPUSchedulerForm";
            this.Padding = new System.Windows.Forms.Padding(35, 109, 35, 36);
            this.Text = "CPU Scheduler (G46)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ProcessGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessComingTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

