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
            //Constant Monthly Interest Rates
            const decimal INTEREST_RATE = 0.005M;

            //Local Variables       
            decimal balance;
            int months;
            int count = 1;

            //Get the starting balance
            if (int.TryParse(txtbxStartingBalance.Text, out months))
            {
                //Get the number of months
                if (decimal.TryParse(txtbxNumberOfMonths.Text,out balance))
                {
                 //Loop to calculate ending balance
                    while (count <= months)
                    {
                        balance = balance + (INTEREST_RATE * balance);
                        count = count + 1;
                    }

                    //Display the ending balance
                    lblEndingBalance.Text = balance.ToString();
                }
                else
                {
                    //Invalid number of months
                    MessageBox.Show("Invalid number of months.");
                }
            }
            else
            {
                //Invalid balance
                MessageBox.Show("Invalid value for starting balance.");
            }
        }

    }
}
