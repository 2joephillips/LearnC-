using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class frmDistanceCalculator : Form
    {
        public frmDistanceCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the Applicaton
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Input Variables from text box
            int mph;
            int hours;

            if (int.TryParse(txtbxMPH.Text,out mph))
            {
                if (int.TryParse(txtbxHoursTraveled.Text , out hours))
                {
                    /* loop to calculate the distance of trip
                    it will start on the first hour and calculate till it reaches the 
                     total number of hours */
                    for (int i = 1; i <= hours; i++)
                    {
                       //Variable to calculate distance 
                       int distance = i * mph;
                       lstbxResults.Items.Add("After hour " + i + " the distance is " + distance);
                    }
                  }
                else
                {
                    MessageBox.Show("Empty or Invalid number in Hours Traveled box.");
                }
            }
            else
            {
                MessageBox.Show("Empty or Invalid number in MPH box.");
            }
            
        }
    }
}
