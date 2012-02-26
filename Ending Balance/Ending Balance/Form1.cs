using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        const decimal MONTHLY_INTEREST = 0.005m;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Inputs and Outputs
            lblEndingBalance.Text = "";
            txtbxNumberOfMonths.Text = "";
            txtbxStartingBalance.Text = "";

            //Set Focus
            txtbxStartingBalance.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables of Inputs
            int NumberOfMonths = int.TryParse(txtbxNumberOfMonths.Text);
            decimal StartingBalance = 0;  
            


        }

    }
}
