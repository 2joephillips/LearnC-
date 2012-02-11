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
            // declare variables for miles, gallons, mpg
            double mpg, gallons, miles;

            //Assign values
            gallons = double.Parse(txtGallons.Text);
            miles = double.Parse(txtMiles.Text);
            // Calculate MPG
            mpg = miles / gallons;

            //Display MPG in Lable
            lblMPG.Text = mpg.ToString();
        }
    }
}
