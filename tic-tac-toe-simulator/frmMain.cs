using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region Properties
        char[,] c2DAns = { {' ', ' ', ' ', },
                           {' ', ' ', ' ', },
                           {' ', ' ', ' ', }};

        bool blnGotWinner = false;
        #endregion

        #region btnNewGame_Click
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lblWin.Text = string.Empty;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.ForeColor = System.Drawing.Color.Black;
                    ctrl.Text = string.Empty;
                }
            }

            // Clear the 2D array
            for (int cols = 0; cols < 3; cols++)
            {
                for (int rows = 0; rows < 3; rows++)
                {
                    c2DAns[rows, cols] = ' ';
                }
            }

            blnGotWinner = false;
            PlaceChoice(3, 3, 9); // Call method to populate the board for a new game
        }
        #endregion

        #region PlaceChoice()
        public void PlaceChoice(int intMaxRows, int intMaxCols, int intNumTiles)
        {
            int intMaxIndex = (intMaxRows * intMaxCols) - 1;
            int intIndex = 0;

            Random turn = new Random();
            int number = turn.Next(0, 2); // Toss coin for first turn
            bool blnPlayer = Convert.ToBoolean(number);

            // Create an array of random and unique numbers within a range
            var random = new Random();
            var tempArray = Enumerable.Range(0, 9).OrderBy(t => random.Next()).ToArray();
            char[] cAnswers = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            // Display who ge the first turn (0 = "O" , 1 = "X")
            if (blnPlayer)
                lblPlayer.Text = "X moved first!";
            else
                lblPlayer.Text = "O moved first!";

            // Place Players at generated indicies
            for (int i = 0; i < 9; ++i)
            {
                intIndex = tempArray[i];
                int x = 0;
                int y = 0;

                // Convert 1D index into 2D indicies
                x = intIndex / intMaxRows;
                y = intIndex % intMaxCols;

                if (blnPlayer) // Set character based upon the turn
                    c2DAns[x, y] = 'X';
                else
                    c2DAns[x, y] = 'O';

                if (intIndex == 0)
                {
                    if (blnPlayer)
                    {
                        lblTopLeft.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblTopLeft.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                else if (intIndex == 1)
                {
                    if (blnPlayer)
                    {
                        lblTopMid.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblTopMid.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                else if (intIndex == 2)
                {
                    if (blnPlayer)
                    {
                        lblTopRight.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblTopRight.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                else if (intIndex == 3)
                {
                    if (blnPlayer)
                    {
                        lblMidLeft.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblMidLeft.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                else if (intIndex == 4)
                {
                    if (blnPlayer)
                    {
                        lblMidMid.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblMidMid.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                else if (intIndex == 5)
                {
                    if (blnPlayer)
                    {
                        lblMidRight.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblMidRight.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                else if (intIndex == 6)
                {
                    if (blnPlayer)
                    {
                        lblBotLeft.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblBotLeft.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                else if (intIndex == 7)
                {
                    if (blnPlayer)
                    {
                        lblBotMid.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblBotMid.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                else
                {
                    if (blnPlayer)
                    {
                        lblBotRight.Text = "X";
                        cAnswers[i] = 'X';
                    }
                    else
                    {
                        lblBotRight.Text = "O";
                        cAnswers[i] = 'O';
                    }
                }
                blnPlayer = !blnPlayer;

                blnGotWinner = CheckWinner();
                if (blnGotWinner)
                    break;
            }
            if (blnGotWinner == false)
            {
                lblWin.Text = "Tie game!";
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Label && ctrl.Name != "lblWin" && ctrl.Name != "lblPlayer")
                    {
                        ctrl.ForeColor = System.Drawing.Color.Coral;
                    }
                }
            }
        }
        #endregion

        #region CheckWinner()
        private bool CheckWinner() // Sets the appropriate colors calc winner
        {
            int intXCount = 0;
            int intOCount = 0;

            // Check rows
            for (int rows = 0; rows < 3; rows++)
            {
                intXCount = 0;
                intOCount = 0;
                for (int cols = 0; cols < 3; cols++)
                {
                    if (c2DAns[rows, cols] == 'X')
                        intXCount++;
                    else if (c2DAns[rows, cols] == 'O')
                        intOCount++;
                }
                if (intXCount == 3 && blnGotWinner == false)
                {
                    lblWin.Text = "X wins!";
                    if (rows == 0)
                    {
                        lblTopLeft.ForeColor = System.Drawing.Color.Red;
                        lblTopMid.ForeColor = System.Drawing.Color.Red;
                        lblTopRight.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (rows == 1)
                    {
                        lblMidLeft.ForeColor = System.Drawing.Color.Red;
                        lblMidMid.ForeColor = System.Drawing.Color.Red;
                        lblMidRight.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (rows == 2)
                    {
                        lblBotLeft.ForeColor = System.Drawing.Color.Red;
                        lblBotMid.ForeColor = System.Drawing.Color.Red;
                        lblBotRight.ForeColor = System.Drawing.Color.Red;
                    }
                    blnGotWinner = true;
                }
                if (intOCount == 3 && blnGotWinner == false)
                {
                    lblWin.Text = "O wins!";
                    if (rows == 0)
                    {
                        lblTopLeft.ForeColor = System.Drawing.Color.Red;
                        lblTopMid.ForeColor = System.Drawing.Color.Red;
                        lblTopRight.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (rows == 1)
                    {
                        lblMidLeft.ForeColor = System.Drawing.Color.Red;
                        lblMidMid.ForeColor = System.Drawing.Color.Red;
                        lblMidRight.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (rows == 2)
                    {
                        lblBotLeft.ForeColor = System.Drawing.Color.Red;
                        lblBotMid.ForeColor = System.Drawing.Color.Red;
                        lblBotRight.ForeColor = System.Drawing.Color.Red;
                    }
                    blnGotWinner = true;
                }
            }
            // Check cols
            for (int cols = 0; cols < 3; cols++)
            {
                intXCount = 0;
                intOCount = 0;
                for (int rows = 0; rows < 3; rows++)
                {
                    if (c2DAns[rows, cols] == 'X')
                        intXCount++;
                    else if (c2DAns[rows, cols] == 'O')
                        intOCount++;
                }
                if (intXCount == 3 && blnGotWinner == false)
                {
                    lblWin.Text = "X wins!";
                    if (cols == 0)
                    {
                        lblTopLeft.ForeColor = System.Drawing.Color.Red;
                        lblMidLeft.ForeColor = System.Drawing.Color.Red;
                        lblBotLeft.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (cols == 1)
                    {
                        lblTopRight.ForeColor = System.Drawing.Color.Red;
                        lblMidRight.ForeColor = System.Drawing.Color.Red;
                        lblBotRight.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (cols == 2)
                    {
                        lblTopRight.ForeColor = System.Drawing.Color.Red;
                        lblMidRight.ForeColor = System.Drawing.Color.Red;
                        lblBotRight.ForeColor = System.Drawing.Color.Red;
                    }
                        blnGotWinner = true;
                }
                if (intOCount == 3 && blnGotWinner == false)
                {
                    lblWin.Text = "O wins!";
                    if (cols == 0)
                    {
                        lblTopLeft.ForeColor = System.Drawing.Color.Red;
                        lblMidLeft.ForeColor = System.Drawing.Color.Red;
                        lblBotLeft.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (cols == 1)
                    {
                        lblTopMid.ForeColor = System.Drawing.Color.Red;
                        lblMidMid.ForeColor = System.Drawing.Color.Red;
                        lblBotMid.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (cols == 2)
                    {
                        lblTopRight.ForeColor = System.Drawing.Color.Red;
                        lblMidRight.ForeColor = System.Drawing.Color.Red;
                        lblBotRight.ForeColor = System.Drawing.Color.Red;
                    }
                    blnGotWinner = true;
                }
            }

            // Check right diagonal
            intXCount = 0;
            intOCount = 0;

            if (blnGotWinner == false)
            {
                if (c2DAns[0, 0] == 'X')
                    intXCount++;
                else if (c2DAns[0, 0] == 'O')
                    intOCount++;
                if (c2DAns[1, 1] == 'X')
                    intXCount++;
                else if (c2DAns[1, 1] == 'O')
                    intOCount++;
                if (c2DAns[2, 2] == 'X')
                    intXCount++;
                else if (c2DAns[2, 2] == 'O')
                    intOCount++;
                if (intXCount == 3 && blnGotWinner == false)
                {
                    lblWin.Text = "X wins!";
                    lblTopLeft.ForeColor = System.Drawing.Color.Red;
                    lblMidMid.ForeColor = System.Drawing.Color.Red;
                    lblBotRight.ForeColor = System.Drawing.Color.Red;
                    blnGotWinner = true;

                }
                if (intOCount == 3 && blnGotWinner == false)
                {
                    lblWin.Text = "O wins!";
                    lblTopLeft.ForeColor = System.Drawing.Color.Red;
                    lblMidMid.ForeColor = System.Drawing.Color.Red;
                    lblBotRight.ForeColor = System.Drawing.Color.Red;
                    blnGotWinner = true;

                }
            }
            // Check left diagonal
            intXCount = 0;
            intOCount = 0;

            if (blnGotWinner == false)
            {
                if (c2DAns[2, 0] == 'X')
                    intXCount++;
                else if (c2DAns[2, 0] == 'O')
                    intOCount++;
                if (c2DAns[1, 1] == 'X')
                    intXCount++;
                else if (c2DAns[1, 1] == 'O')
                    intOCount++;
                if (c2DAns[0, 2] == 'X')
                    intXCount++;
                else if (c2DAns[0, 2] == 'O')
                    intOCount++;
                if (intXCount == 3 && blnGotWinner == false)
                {
                    lblWin.Text = "X wins!";
                    lblTopRight.ForeColor = System.Drawing.Color.Red;
                    lblMidMid.ForeColor = System.Drawing.Color.Red;
                    lblBotLeft.ForeColor = System.Drawing.Color.Red;
                    blnGotWinner = true;

                }
                if (intOCount == 3 && blnGotWinner == false)
                {
                    lblWin.Text = "O wins!";
                    lblTopRight.ForeColor = System.Drawing.Color.Red;
                    lblMidMid.ForeColor = System.Drawing.Color.Red;
                    lblBotLeft.ForeColor = System.Drawing.Color.Red;
                    blnGotWinner = true;

                }
            }

            if (blnGotWinner)
                return true;
            else
                return false;
        }

        #endregion

        #region btnExit_Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
