using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loan_Qualifier
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
            //Clear input and output variables
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            //Reset Focus
            salaryTextBox.Focus();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Names constants
                const decimal MINIMUM_SALARY = 40m;
                const int MINIMUN_YEARS_ON_THE_JOB = 2;

                //Local Variables
                decimal salary;
                int yearsOnJob;

                //Get the salary and years on the job.
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                //Determine whether the user qualifies
                if (salary >= MINIMUM_SALARY)
                {
                    if(yearsOnJob >= MINIMUN_YEARS_ON_THE_JOB)
                    {
                        //The user Qualifies 
                        decisionLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        //The user does not qualify
                        decisionLabel.Text = "Minimum years at current job not met.";
                    }
                }
                 else
                {
                        // The user does not qualify 
                        decisionLabel.Text = "Minimum salary requirement not met.";
	            }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
