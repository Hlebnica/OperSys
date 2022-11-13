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
            this.components = new System.ComponentModel.Container();
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
            this.SJF_groupBox = new System.Windows.Forms.GroupBox();
            this.AddNewCustomSJF_button = new System.Windows.Forms.Button();
            this.MemoryCustom_SJF_textBox = new System.Windows.Forms.TextBox();
            this.SecondProcess_Middle_button = new System.Windows.Forms.Button();
            this.CPUCustom_SJF_textBox = new System.Windows.Forms.TextBox();
            this.SecondProcess_Low_button = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Timer_form = new System.Windows.Forms.Timer(this.components);
            this.FCFS_groupBox.SuspendLayout();
            this.SJF_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CentralProcess
            // 
            this.CentralProcess.Location = new System.Drawing.Point(64, 54);
            this.CentralProcess.Name = "CentralProcess";
            this.CentralProcess.Size = new System.Drawing.Size(28, 18);
            this.CentralProcess.TabIndex = 0;
            this.CentralProcess.Text = "ЦП\r\n";
            // 
            // Memory
            // 
            this.Memory.Location = new System.Drawing.Point(64, 80);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(48, 16);
            this.Memory.TabIndex = 1;
            this.Memory.Text = "Память";
            // 
            // ProcessList
            // 
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.Location = new System.Drawing.Point(198, 8);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(408, 316);
            this.ProcessList.TabIndex = 2;
            // 
            // AddProcessLow
            // 
            this.AddProcessLow.Location = new System.Drawing.Point(5, 18);
            this.AddProcessLow.Name = "AddProcessLow";
            this.AddProcessLow.Size = new System.Drawing.Size(188, 41);
            this.AddProcessLow.TabIndex = 3;
            this.AddProcessLow.Text = "Маленький процесс";
            this.AddProcessLow.UseVisualStyleBackColor = true;
            this.AddProcessLow.Click += new System.EventHandler(this.AddProcessLow_Click);
            // 
            // AddProcessMiddle
            // 
            this.AddProcessMiddle.Location = new System.Drawing.Point(6, 77);
            this.AddProcessMiddle.Name = "AddProcessMiddle";
            this.AddProcessMiddle.Size = new System.Drawing.Size(187, 43);
            this.AddProcessMiddle.TabIndex = 4;
            this.AddProcessMiddle.Text = "Процесс побольше";
            this.AddProcessMiddle.UseVisualStyleBackColor = true;
            this.AddProcessMiddle.Click += new System.EventHandler(this.AddProcessMiddle_Click);
            // 
            // CP_Counter_label
            // 
            this.CP_Counter_label.Location = new System.Drawing.Point(10, 52);
            this.CP_Counter_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CP_Counter_label.Name = "CP_Counter_label";
            this.CP_Counter_label.Size = new System.Drawing.Size(48, 17);
            this.CP_Counter_label.TabIndex = 5;
            this.CP_Counter_label.Text = "0";
            this.CP_Counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Memory_Counter_label
            // 
            this.Memory_Counter_label.Location = new System.Drawing.Point(10, 80);
            this.Memory_Counter_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Memory_Counter_label.Name = "Memory_Counter_label";
            this.Memory_Counter_label.Size = new System.Drawing.Size(48, 17);
            this.Memory_Counter_label.TabIndex = 6;
            this.Memory_Counter_label.Text = "0";
            this.Memory_Counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentTime_label
            // 
            this.CurrentTime_label.Location = new System.Drawing.Point(10, 30);
            this.CurrentTime_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentTime_label.Name = "CurrentTime_label";
            this.CurrentTime_label.Size = new System.Drawing.Size(110, 19);
            this.CurrentTime_label.TabIndex = 7;
            this.CurrentTime_label.Text = "-";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Системное время:";
            // 
            // CPCustomProcess_textBox
            // 
            this.CPCustomProcess_textBox.Location = new System.Drawing.Point(6, 125);
            this.CPCustomProcess_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPCustomProcess_textBox.Name = "CPCustomProcess_textBox";
            this.CPCustomProcess_textBox.Size = new System.Drawing.Size(85, 20);
            this.CPCustomProcess_textBox.TabIndex = 9;
            // 
            // MemoryCustomProcess_textBox
            // 
            this.MemoryCustomProcess_textBox.Location = new System.Drawing.Point(5, 157);
            this.MemoryCustomProcess_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.MemoryCustomProcess_textBox.Name = "MemoryCustomProcess_textBox";
            this.MemoryCustomProcess_textBox.Size = new System.Drawing.Size(86, 20);
            this.MemoryCustomProcess_textBox.TabIndex = 10;
            // 
            // AddNewCustomProcess_button
            // 
            this.AddNewCustomProcess_button.Location = new System.Drawing.Point(95, 125);
            this.AddNewCustomProcess_button.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewCustomProcess_button.Name = "AddNewCustomProcess_button";
            this.AddNewCustomProcess_button.Size = new System.Drawing.Size(98, 50);
            this.AddNewCustomProcess_button.TabIndex = 11;
            this.AddNewCustomProcess_button.Text = "Настраиваемый процесс";
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
            this.FCFS_groupBox.Location = new System.Drawing.Point(19, 365);
            this.FCFS_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCFS_groupBox.Name = "FCFS_groupBox";
            this.FCFS_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.FCFS_groupBox.Size = new System.Drawing.Size(202, 192);
            this.FCFS_groupBox.TabIndex = 12;
            this.FCFS_groupBox.TabStop = false;
            this.FCFS_groupBox.Text = "FCFS";
            this.FCFS_groupBox.Visible = false;
            // 
            // SJF_groupBox
            // 
            this.SJF_groupBox.Controls.Add(this.AddNewCustomSJF_button);
            this.SJF_groupBox.Controls.Add(this.MemoryCustom_SJF_textBox);
            this.SJF_groupBox.Controls.Add(this.SecondProcess_Middle_button);
            this.SJF_groupBox.Controls.Add(this.CPUCustom_SJF_textBox);
            this.SJF_groupBox.Controls.Add(this.SecondProcess_Low_button);
            this.SJF_groupBox.Location = new System.Drawing.Point(248, 365);
            this.SJF_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SJF_groupBox.Name = "SJF_groupBox";
            this.SJF_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SJF_groupBox.Size = new System.Drawing.Size(196, 192);
            this.SJF_groupBox.TabIndex = 13;
            this.SJF_groupBox.TabStop = false;
            this.SJF_groupBox.Text = "SJF";
            this.SJF_groupBox.Visible = false;
            // 
            // AddNewCustomSJF_button
            // 
            this.AddNewCustomSJF_button.Location = new System.Drawing.Point(94, 127);
            this.AddNewCustomSJF_button.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewCustomSJF_button.Name = "AddNewCustomSJF_button";
            this.AddNewCustomSJF_button.Size = new System.Drawing.Size(98, 50);
            this.AddNewCustomSJF_button.TabIndex = 18;
            this.AddNewCustomSJF_button.Text = "Настраиваемый процесс";
            this.AddNewCustomSJF_button.UseVisualStyleBackColor = true;
            this.AddNewCustomSJF_button.Click += new System.EventHandler(this.AddNewCustomSJF_button_Click);
            // 
            // MemoryCustom_SJF_textBox
            // 
            this.MemoryCustom_SJF_textBox.Location = new System.Drawing.Point(4, 159);
            this.MemoryCustom_SJF_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.MemoryCustom_SJF_textBox.Name = "MemoryCustom_SJF_textBox";
            this.MemoryCustom_SJF_textBox.Size = new System.Drawing.Size(86, 20);
            this.MemoryCustom_SJF_textBox.TabIndex = 17;
            // 
            // SecondProcess_Middle_button
            // 
            this.SecondProcess_Middle_button.Location = new System.Drawing.Point(4, 77);
            this.SecondProcess_Middle_button.Margin = new System.Windows.Forms.Padding(2);
            this.SecondProcess_Middle_button.Name = "SecondProcess_Middle_button";
            this.SecondProcess_Middle_button.Size = new System.Drawing.Size(188, 43);
            this.SecondProcess_Middle_button.TabIndex = 17;
            this.SecondProcess_Middle_button.Text = "Процесс побольше";
            this.SecondProcess_Middle_button.UseVisualStyleBackColor = true;
            this.SecondProcess_Middle_button.Click += new System.EventHandler(this.SecondProcess_Middle_button_Click);
            // 
            // CPUCustom_SJF_textBox
            // 
            this.CPUCustom_SJF_textBox.Location = new System.Drawing.Point(5, 127);
            this.CPUCustom_SJF_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.CPUCustom_SJF_textBox.Name = "CPUCustom_SJF_textBox";
            this.CPUCustom_SJF_textBox.Size = new System.Drawing.Size(85, 20);
            this.CPUCustom_SJF_textBox.TabIndex = 16;
            // 
            // SecondProcess_Low_button
            // 
            this.SecondProcess_Low_button.Location = new System.Drawing.Point(4, 18);
            this.SecondProcess_Low_button.Margin = new System.Windows.Forms.Padding(2);
            this.SecondProcess_Low_button.Name = "SecondProcess_Low_button";
            this.SecondProcess_Low_button.Size = new System.Drawing.Size(192, 41);
            this.SecondProcess_Low_button.TabIndex = 16;
            this.SecondProcess_Low_button.Text = "Маленький процесс";
            this.SecondProcess_Low_button.UseVisualStyleBackColor = true;
            this.SecondProcess_Low_button.Click += new System.EventHandler(this.SecondProcess_Low_button_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(25, 131);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 27);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FCFS";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(25, 162);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 27);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SJF";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Timer_form
            // 
            this.Timer_form.Tick += new System.EventHandler(this.Timer_form_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 610);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.SJF_groupBox);
            this.Controls.Add(this.FCFS_groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentTime_label);
            this.Controls.Add(this.Memory_Counter_label);
            this.Controls.Add(this.CP_Counter_label);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.CentralProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FCFS_groupBox.ResumeLayout(false);
            this.FCFS_groupBox.PerformLayout();
            this.SJF_groupBox.ResumeLayout(false);
            this.SJF_groupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Timer Timer_form;

        private System.Windows.Forms.Button AddNewCustomSJF_button;
        private System.Windows.Forms.TextBox MemoryCustom_SJF_textBox;
        private System.Windows.Forms.TextBox CPUCustom_SJF_textBox;

        private System.Windows.Forms.Button SecondProcess_Low_button;

        private System.Windows.Forms.Button SecondProcess_Middle_button;

        private System.Windows.Forms.RadioButton radioButton2;

        private System.Windows.Forms.RadioButton radioButton1;

        private System.Windows.Forms.GroupBox SJF_groupBox;

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