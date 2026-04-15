using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5
{
    public partial class frmMain : Form
    {
        int RandomNumber; // Randome number variable
        Random rng = new Random();

        int ClickCount = 0; // Click Count variable
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            RandomNumber = rng.Next(1, 101); // A number from 1-100
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            int Guess;

            if (!int.TryParse(txtGuess.Text, out Guess)) // Takes number input
            {
                MessageBox.Show("Please enter a valid number."); // Ensures no crash if letters are input
                return;
            }

            lblExit.Visible = true; // Give up text
            
            ClickCount++; // Adds to click count

            if (Guess < RandomNumber) 
            {
                lblLow.Visible = true;
                lblHigh.Visible = false;

                lblCongrats.Visible = false;
                lblAttempts.Visible = false;
            }
            else if (Guess > RandomNumber)
            {
                lblLow.Visible = false;
                lblHigh.Visible = true;

                lblCongrats.Visible = false;
                lblAttempts.Visible = false;
            }
            else
            {
                lblLow.Visible = false;
                lblHigh.Visible = false;

                lblCongrats.Visible = true;
                lblAttempts.Text = "Attempts: " + ClickCount.ToString();
                lblAttempts.Visible = true;

                RandomNumber = rng.Next(1, 101); // New number for next game
                ClickCount = 0; // Reset attempts
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
