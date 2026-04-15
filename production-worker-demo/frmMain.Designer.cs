namespace Project10
{
    partial class frmMain
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
            this.lblEmpName = new System.Windows.Forms.Label();
            this.lblEmpNumber = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpNumber = new System.Windows.Forms.TextBox();
            this.grpShiftNumber = new System.Windows.Forms.GroupBox();
            this.rdoDay2 = new System.Windows.Forms.RadioButton();
            this.rdoDay1 = new System.Windows.Forms.RadioButton();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpShiftNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Location = new System.Drawing.Point(25, 24);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(175, 25);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "Employee Name:";
            // 
            // lblEmpNumber
            // 
            this.lblEmpNumber.AutoSize = true;
            this.lblEmpNumber.Location = new System.Drawing.Point(25, 74);
            this.lblEmpNumber.Name = "lblEmpNumber";
            this.lblEmpNumber.Size = new System.Drawing.Size(194, 25);
            this.lblEmpNumber.TabIndex = 1;
            this.lblEmpNumber.Text = "Employee Number:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(248, 21);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(315, 31);
            this.txtEmpName.TabIndex = 2;
            // 
            // txtEmpNumber
            // 
            this.txtEmpNumber.Location = new System.Drawing.Point(248, 71);
            this.txtEmpNumber.Name = "txtEmpNumber";
            this.txtEmpNumber.Size = new System.Drawing.Size(315, 31);
            this.txtEmpNumber.TabIndex = 3;
            // 
            // grpShiftNumber
            // 
            this.grpShiftNumber.Controls.Add(this.rdoDay2);
            this.grpShiftNumber.Controls.Add(this.rdoDay1);
            this.grpShiftNumber.Location = new System.Drawing.Point(30, 129);
            this.grpShiftNumber.Name = "grpShiftNumber";
            this.grpShiftNumber.Size = new System.Drawing.Size(533, 83);
            this.grpShiftNumber.TabIndex = 4;
            this.grpShiftNumber.TabStop = false;
            this.grpShiftNumber.Text = "Shift Number:";
            // 
            // rdoDay2
            // 
            this.rdoDay2.AutoSize = true;
            this.rdoDay2.Location = new System.Drawing.Point(386, 30);
            this.rdoDay2.Name = "rdoDay2";
            this.rdoDay2.Size = new System.Drawing.Size(122, 29);
            this.rdoDay2.TabIndex = 1;
            this.rdoDay2.TabStop = true;
            this.rdoDay2.Text = "night (2)";
            this.rdoDay2.UseVisualStyleBackColor = true;
            this.rdoDay2.CheckedChanged += new System.EventHandler(this.rdoDay2_CheckedChanged);
            // 
            // rdoDay1
            // 
            this.rdoDay1.AutoSize = true;
            this.rdoDay1.Location = new System.Drawing.Point(230, 30);
            this.rdoDay1.Name = "rdoDay1";
            this.rdoDay1.Size = new System.Drawing.Size(110, 29);
            this.rdoDay1.TabIndex = 0;
            this.rdoDay1.TabStop = true;
            this.rdoDay1.Text = "day (1)";
            this.rdoDay1.UseVisualStyleBackColor = true;
            this.rdoDay1.Click += new System.EventHandler(this.rdoDay1_Click);
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(25, 236);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(192, 25);
            this.lblHourlyRate.TabIndex = 5;
            this.lblHourlyRate.Text = "Hourly Pay Rate: $";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(248, 233);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(315, 31);
            this.txtHourlyRate.TabIndex = 6;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(30, 281);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(121, 45);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(30, 340);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(533, 171);
            this.lblOutput.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(442, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 529);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.grpShiftNumber);
            this.Controls.Add(this.txtEmpNumber);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpNumber);
            this.Controls.Add(this.lblEmpName);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production Worker Class";
            this.grpShiftNumber.ResumeLayout(false);
            this.grpShiftNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label lblEmpNumber;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpNumber;
        private System.Windows.Forms.GroupBox grpShiftNumber;
        private System.Windows.Forms.RadioButton rdoDay2;
        private System.Windows.Forms.RadioButton rdoDay1;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnExit;
    }
}

