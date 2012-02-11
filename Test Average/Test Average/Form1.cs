using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare Variables
                double test1, test2, test3, average;
                test1 = double.Parse(txtbxTest1.Text);
                test2 = double.Parse(txtbxTest2.Text);
                test3 = double.Parse(txtbxTest3.Text);

                //Calculate the average
                average = (test1 + test2 + test3) / 3.0;

                //Display the average test score.
                // the output rounded to 1 decimal point
                lblAverage.Text = average.ToString("n1");
            }
            catch (Exception ex)
            {
                //Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear input and output controls
            lblAverage.Text = "";
            txtbxTest1.Text = "";
            txtbxTest2.Text = "";
            txtbxTest3.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }
    }
}
