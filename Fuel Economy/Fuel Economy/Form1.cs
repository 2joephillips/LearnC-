using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class frmFuelEconomy : Form
    {
        public frmFuelEconomy()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Input Variables
            double miles = 0;
            double gallons = 0;

            //Output Variables
            double mpg = 0;

            if (double.TryParse(txtMiles.Text, out miles))
            {
                if (double.TryParse(txtGallons.Text, out gallons))
                {
                    mpg = miles / gallons;
                    lblMPG.Text = mpg.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Invalid input for gallons.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for miles.");
            }
        }
        }
}
