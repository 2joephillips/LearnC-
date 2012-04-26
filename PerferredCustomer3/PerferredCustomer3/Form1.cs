using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PerferredCustomer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateDiscount_Click(object sender, EventArgs e)
        {
            try 
	        {	        
	
            PerferredCustomer customer = new PerferredCustomer();
            customer.Name = txtname.Text.ToString();
            customer.Address = txtAddress.Text.ToString();
            customer.Name = txtNumber.Text.ToString();
            customer.TotalSales = int.Parse(txtSales.Text.ToString());
            customer.DiscountAmount();

            MessageBox.Show("The discount for this customer will be " + customer.Discount.ToString("p"));	
	        }
	        catch (Exception)
            {
                MessageBox.Show("Enter number for total sales.");
	        }
        }
    }
}