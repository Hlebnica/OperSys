namespace PlanningProcess
{
    partial class Form1
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
            this.CentralProcess = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.Label();
            this.ProcessList = new System.Windows.Forms.ListBox();
            this.AddProcessLow = new System.Windows.Forms.Button();
            this.AddProcessMiddle = new System.Windows.Forms.Button();
            this.CP_Counter_label = new System.Windows.Forms.Label();
            this.Memory_Counter_label = new System.Windows.Forms.Label();
            this.CurrentTime_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CPCustomProcess_textBox = new System.Windows.Forms.TextBox();
            this.MemoryCustomProcess_textBox = new System.Windows.Forms.TextBox();
            this.AddNewCustomProcess_button = new System.Windows.Forms.Button();
            this.FCFS_groupBox = new System.Windows.Forms.GroupBox();
            this.RR_groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.FCFS_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CentralProcess
            // 
            this.CentralProcess.Location = new System.Drawing.Point(85, 66);
            this.CentralProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CentralProcess.Name = "CentralProcess";
            this.CentralProcess.Size = new System.Drawing.Size(38, 22);
            this.CentralProcess.TabIndex = 0;
            this.CentralProcess.Text = "ЦП\r\n";
            this.CentralProcess.Click += new System.EventHandler(this.CentralProcess_Click);
            // 
            // Memory
            // 
            this.Memory.Location = new System.Drawing.Point(85, 99);
            this.Memory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(64, 20);
            this.Memory.TabIndex = 1;
            this.Memory.Text = "Память";
            // 
            // ProcessList
            // 
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.ItemHeight = 16;
            this.ProcessList.Location = new System.Drawing.Point(264, 10);
            this.ProcessList.Margin = new System.Windows.Forms.Padding(4);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(543, 388);
            this.ProcessList.TabIndex = 2;
            this.ProcessList.SelectedIndexChanged += new System.EventHandler(this.ProcessList_SelectedIndexChanged);
            // 
            // AddProcessLow
            // 
            this.AddProcessLow.Location = new System.Drawing.Point(7, 22);
            this.AddProcessLow.Margin = new System.Windows.Forms.Padding(4);
            this.AddProcessLow.Name = "AddProcessLow";
            this.AddProcessLow.Size = new System.Drawing.Size(195, 50);
            this.AddProcessLow.TabIndex = 3;
            this.AddProcessLow.Text = "Add1";
            this.AddProcessLow.UseVisualStyleBackColor = true;
            this.AddProcessLow.Click += new System.EventHandler(this.AddProcessLow_Click);
            // 
            // AddProcessMiddle
            // 
            this.AddProcessMiddle.Location = new System.Drawing.Point(8, 95);
            this.AddProcessMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.AddProcessMiddle.Name = "AddProcessMiddle";
            this.AddProcessMiddle.Size = new System.Drawing.Size(192, 53);
            this.AddProcessMiddle.TabIndex = 4;
            this.AddProcessMiddle.Text = "Add2";
            this.AddProcessMiddle.UseVisualStyleBackColor = true;
            this.AddProcessMiddle.Click += new System.EventHandler(this.AddProcessMiddle_Click);
            // 
            // CP_Counter_label
            // 
            this.CP_Counter_label.Location = new System.Drawing.Point(14, 64);
            this.CP_Counter_label.Name = "CP_Counter_label";
            this.CP_Counter_label.Size = new System.Drawing.Size(64, 21);
            this.CP_Counter_label.TabIndex = 5;
            this.CP_Counter_label.Text = "0";
            this.CP_Counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Memory_Counter_label
            // 
            this.Memory_Counter_label.Location = new System.Drawing.Point(14, 99);
            this.Memory_Counter_label.Name = "Memory_Counter_label";
            this.Memory_Counter_label.Size = new System.Drawing.Size(64, 21);
            this.Memory_Counter_label.TabIndex = 6;
            this.Memory_Counter_label.Text = "0";
            this.Memory_Counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Memory_Counter_label.Click += new System.EventHandler(this.Memory_Counter_label_Click);
            // 
            // CurrentTime_label
            // 
            this.CurrentTime_label.Location = new System.Drawing.Point(14, 37);
            this.CurrentTime_label.Name = "CurrentTime_label";
            this.CurrentTime_label.Size = new System.Drawing.Size(147, 23);
            this.CurrentTime_label.TabIndex = 7;
            this.CurrentTime_label.Text = "-";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Системное время:";
            // 
            // CPCustomProcess_textBox
            // 
            this.CPCustomProcess_textBox.Location = new System.Drawing.Point(8, 177);
            this.CPCustomProcess_textBox.Name = "CPCustomProcess_textBox";
            this.CPCustomProcess_textBox.Size = new System.Drawing.Size(112, 22);
            this.CPCustomProcess_textBox.TabIndex = 9;
            // 
            // MemoryCustomProcess_textBox
            // 
            this.MemoryCustomProcess_textBox.Location = new System.Drawing.Point(7, 216);
            this.MemoryCustomProcess_textBox.Name = "MemoryCustomProcess_textBox";
            this.MemoryCustomProcess_textBox.Size = new System.Drawing.Size(113, 22);
            this.MemoryCustomProcess_textBox.TabIndex = 10;
            // 
            // AddNewCustomProcess_button
            // 
            this.AddNewCustomProcess_button.Location = new System.Drawing.Point(133, 177);
            this.AddNewCustomProcess_button.Name = "AddNewCustomProcess_button";
            this.AddNewCustomProcess_button.Size = new System.Drawing.Size(69, 61);
            this.AddNewCustomProcess_button.TabIndex = 11;
            this.AddNewCustomProcess_button.Text = "Add Custom";
            this.AddNewCustomProcess_button.UseVisualStyleBackColor = true;
            this.AddNewCustomProcess_button.Click += new System.EventHandler(this.AddNewCustomProcess_button_Click);
            // 
            // FCFS_groupBox
            // 
            this.FCFS_groupBox.Controls.Add(this.AddProcessLow);
            this.FCFS_groupBox.Controls.Add(this.AddNewCustomProcess_button);
            this.FCFS_groupBox.Controls.Add(this.AddProcessMiddle);
            this.FCFS_groupBox.Controls.Add(this.MemoryCustomProcess_textBox);
            this.FCFS_groupBox.Controls.Add(this.CPCustomProcess_textBox);
            this.FCFS_groupBox.Location = new System.Drawing.Point(25, 449);
            this.FCFS_groupBox.Name = "FCFS_groupBox";
            this.FCFS_groupBox.Size = new System.Drawing.Size(221, 256);
            this.FCFS_groupBox.TabIndex = 12;
            this.FCFS_groupBox.TabStop = false;
            this.FCFS_groupBox.Text = "FCFS";
            this.FCFS_groupBox.Visible = false;
            // 
            // RR_groupBox
            // 
            this.RR_groupBox.Location = new System.Drawing.Point(264, 449);
            this.RR_groupBox.Name = "RR_groupBox";
            this.RR_groupBox.Size = new System.Drawing.Size(266, 256);
            this.RR_groupBox.TabIndex = 13;
            this.RR_groupBox.TabStop = false;
            this.RR_groupBox.Text = "RR";
            this.RR_groupBox.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(33, 161);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 33);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FCFS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(33, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 33);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "RR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 751);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.RR_groupBox);
            this.Controls.Add(this.FCFS_groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentTime_label);
            this.Controls.Add(this.Memory_Counter_label);
            this.Controls.Add(this.CP_Counter_label);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.CentralProcess);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FCFS_groupBox.ResumeLayout(false);
            this.FCFS_groupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.RadioButton radioButton1;

        private System.Windows.Forms.GroupBox RR_groupBox;

        private System.Windows.Forms.GroupBox FCFS_groupBox;

        private System.Windows.Forms.TextBox CPCustomProcess_textBox;
        private System.Windows.Forms.TextBox MemoryCustomProcess_textBox;
        private System.Windows.Forms.Button AddNewCustomProcess_button;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label CurrentTime_label;

        private System.Windows.Forms.Label CP_Counter_label;
        private System.Windows.Forms.Label Memory_Counter_label;

        private System.Windows.Forms.Button AddProcessMiddle;

        private System.Windows.Forms.Button AddProcessLow;

        private System.Windows.Forms.ListBox ProcessList;

        private System.Windows.Forms.Label Memory;

        private System.Windows.Forms.Label CentralProcess;

        #endregion
    }
}