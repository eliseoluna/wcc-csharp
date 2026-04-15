namespace Project5
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
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(67, 18);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(176, 13);
            this.lblGuess.TabIndex = 3;
            this.lblGuess.Text = "Guess a number from 1 through 100";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(67, 138);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(85, 13);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "Do you give up?";
            this.lblExit.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(295, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(167, 62);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 20);
            this.txtGuess.TabIndex = 6;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.ForeColor = System.Drawing.Color.Red;
            this.lblHigh.Location = new System.Drawing.Point(273, 62);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(98, 13);
            this.lblHigh.TabIndex = 7;
            this.lblHigh.Text = "Too high, try again.";
            this.lblHigh.Visible = false;
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.ForeColor = System.Drawing.Color.Red;
            this.lblLow.Location = new System.Drawing.Point(67, 62);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(94, 13);
            this.lblLow.TabIndex = 8;
            this.lblLow.Text = "Too low, try again.";
            this.lblLow.Visible = false;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Location = new System.Drawing.Point(166, 96);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(101, 13);
            this.lblCongrats.TabIndex = 9;
            this.lblCongrats.Text = "Congrats! Go again!";
            this.lblCongrats.Visible = false;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(295, 13);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 10;
            this.btnGuess.Text = "&Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(182, 118);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(51, 13);
            this.lblAttempts.TabIndex = 11;
            this.lblAttempts.Text = "Attempts:";
            this.lblAttempts.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 175);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblGuess);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblAttempts;
    }
}

