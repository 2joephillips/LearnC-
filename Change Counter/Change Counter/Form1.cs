using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        //Constant fields
        private const decimal Five_Cents_Value = 0.05m;
        private const decimal Ten_Cents_Value = 0.10m;
        private const decimal Twenty_Five_Cents_Value = 0.25m;
        private const decimal Fifty_Cents_Value = 0.50m;
        
        //Initialized total to 0
        private decimal total = 0m;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();

        }

        private void picbx5Cent_Click(object sender, EventArgs e)
        {
            //Add 5 cents to total value
            total += Five_Cents_Value;

            //Update total, formatted to Currency
            lblTotal.Text = total.ToString("c");
        }

        private void picbx10Cent_Click(object sender, EventArgs e)
        {
            //Add 10 cents to total value
            total += Ten_Cents_Value;

            //Update total, formatted to Currency
            lblTotal.Text = total.ToString("c");
        }

        private void picbx25Cent_Click(object sender, EventArgs e)
        {
            //Add 25 cents to total value
            total += Twenty_Five_Cents_Value;

            //Update total, formatted to Currency
            lblTotal.Text = total.ToString("c");
        }

        private void picbx50Cent_Click(object sender, EventArgs e)
        {
            //Add 50 cents to total value
            total += Fifty_Cents_Value;

            //Update total, formatted to Currency
            lblTotal.Text = total.ToString("c");
        }
    }
}
