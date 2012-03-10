using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        //Constatn field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        //The InputIsValid method converts the user input and stores
        //it in the arguments (passed by reference). If the coversion 
        //is successful, the method returns true. Otherwise it returns
        //false.
        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            //Flag variable to indicate whether the input is good 
            bool inputGood = false;

            //Try to convert both inputs to decimal. 
            if (decimal.TryParse(grossPayTextBox.Text, out pay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    //Both inputs are good. 
                    inputGood = true;
                }
                else
                {
                    //Display an error mesage for the bonus.
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                //Display an error message for pay.
                MessageBox.Show("Gross Pay is invalid.");
            }

            //Return the result.
            return inputGood;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variables for gross pay, bonus, and contributions
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if (InputIsValid(ref grossPay, ref bonus))
            {
                //Calculate the amount of contribution
                contributions = (grossPay + bonus) * CONTRIB_RATE;

                //Display the contribution 
                contributionLabel.Text = contributions.ToString("c");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //CLose the form. 
            this.Close();
        }

    }
}
