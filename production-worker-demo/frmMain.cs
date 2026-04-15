using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Declarations
        ProductionWorker pdWorker = new ProductionWorker();
        #endregion

        #region btnDisplay()
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                pdWorker.Name = txtEmpName.Text;
                pdWorker.Number = int.Parse(txtEmpNumber.Text);
                pdWorker.HourlyRate = double.Parse(txtHourlyRate.Text);

                lblOutput.Text = "Employee Name: " + pdWorker.Name + "\n" +
                                 "Employee Number: " + pdWorker.Number + "\n" +
                                 "Shift Number: " + pdWorker.ShiftNum + "\n" +
                                 "Hourly pay rate: " + pdWorker.HourlyRate.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region rdoDay1Click()
        private void rdoDay1_Click(object sender, EventArgs e)
        {
            if (rdoDay1.Checked)
            {
                pdWorker.ShiftNum = 1;
            }
        }

        #endregion

        #region rdoDay2_CheckedChanged()
        private void rdoDay2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDay2.Checked)
            {
                pdWorker.ShiftNum = 2;
            }
        }

        #endregion

        #region btnExit_Click()
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
