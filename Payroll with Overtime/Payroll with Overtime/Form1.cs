using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear input and output controls
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            //Reset focus 
            hoursWorkedTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Name constants
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                //Local variables
                decimal hoursWorked;
                decimal hourlyPayRate;
                decimal basePay;
                decimal overtimeHours;
                decimal overtimePay;
                decimal grossPay;

                //Get the hours worked and hourly pay rate.
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                //Determine the gross pay.
                if (hoursWorked > BASE_HOURS)
                {
                    //Calculate the base pay 
                    basePay = hourlyPayRate * BASE_HOURS;

                    //Calculate the number of overtime hours.
                    overtimeHours = hoursWorked - BASE_HOURS;

                    //Calculate overtime pay
                    overtimePay = overtimeHours * OT_MULTIPLIER;

                    //Calculate the gross pay.
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    //Calculate gross pay.
                    grossPay = hoursWorked * hourlyPayRate;
                }

                //Display the gross pay.
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
