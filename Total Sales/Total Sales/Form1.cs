using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Applicaiton
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Variables
                decimal sales;
                decimal total = 0m;

                //Declare a StreamReader 
                StreamReader inputfile;

                //Create StreamReader object
                inputfile = File.OpenText("Sales.txt");

                //Read Inputfile
                while (!inputfile.EndOfStream)
                {
                    //Get Amount of Sales
                    sales = decimal.Parse(inputfile.ReadLine());

                    //Add the Sales to the Total Sales
                    total += sales;
                    
                }

                //Close File
                inputfile.Close();

                //Display Total
                totalLabel.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
