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
            this.SuspendLayout();
            // 
            // CentralProcess
            // 
            this.CentralProcess.Location = new System.Drawing.Point(85, 12);
            this.CentralProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CentralProcess.Name = "CentralProcess";
            this.CentralProcess.Size = new System.Drawing.Size(38, 22);
            this.CentralProcess.TabIndex = 0;
            this.CentralProcess.Text = "ЦП\r\n";
            this.CentralProcess.Click += new System.EventHandler(this.CentralProcess_Click);
            // 
            // Memory
            // 
            this.Memory.Location = new System.Drawing.Point(85, 45);
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
            this.ProcessList.Size = new System.Drawing.Size(727, 388);
            this.ProcessList.TabIndex = 2;
            this.ProcessList.SelectedIndexChanged += new System.EventHandler(this.ProcessList_SelectedIndexChanged);
            // 
            // AddProcessLow
            // 
            this.AddProcessLow.Location = new System.Drawing.Point(13, 487);
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
            this.AddProcessMiddle.Location = new System.Drawing.Point(14, 560);
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
            this.CP_Counter_label.Location = new System.Drawing.Point(14, 10);
            this.CP_Counter_label.Name = "CP_Counter_label";
            this.CP_Counter_label.Size = new System.Drawing.Size(64, 21);
            this.CP_Counter_label.TabIndex = 5;
            this.CP_Counter_label.Text = "0";
            this.CP_Counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Memory_Counter_label
            // 
            this.Memory_Counter_label.Location = new System.Drawing.Point(14, 45);
            this.Memory_Counter_label.Name = "Memory_Counter_label";
            this.Memory_Counter_label.Size = new System.Drawing.Size(64, 21);
            this.Memory_Counter_label.TabIndex = 6;
            this.Memory_Counter_label.Text = "0";
            this.Memory_Counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Memory_Counter_label.Click += new System.EventHandler(this.Memory_Counter_label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 624);
            this.Controls.Add(this.Memory_Counter_label);
            this.Controls.Add(this.CP_Counter_label);
            this.Controls.Add(this.AddProcessMiddle);
            this.Controls.Add(this.AddProcessLow);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.CentralProcess);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

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