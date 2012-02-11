using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateSalePrice_Click(object sender, EventArgs e)
        {
            //Declare Variables
            decimal OriginalPrice;
            decimal DiscountPercentage;
            decimal DiscountAmount;
            decimal SalesPrice;

            //Assign input to variables
            OriginalPrice = decimal.Parse(txtbxOriginalPrice.Text);
            DiscountPercentage = decimal.Parse(txtbxDiscount.Text);

            //Covert DiscountPercentage
            DiscountPercentage = DiscountPercentage / 100;
            
            //Calculate the Discount Amount
            DiscountAmount = OriginalPrice * DiscountPercentage;

            //Calculate Sales Price
            SalesPrice = OriginalPrice - DiscountAmount;

            //Dispaly Sales Price
            lblSalePrice.Text = SalesPrice.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }
    }
}
