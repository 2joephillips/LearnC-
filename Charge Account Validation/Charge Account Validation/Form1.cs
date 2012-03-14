using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Charge_Account_Validation
{
    public partial class chargeAccountValidation : Form
    {
        public chargeAccountValidation()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close Form.
            this.Close();
        }

        private void btnValidateAccountNumber_Click(object sender, EventArgs e)
        {
            //Declare Variable and intialize variable for users input and return account number.
            string input = txtbxChargeAccount.Text;
            int accountNumber = 0;

            //Declare Variable for Account Number file.
            string fileName = "ChargeAccounts.txt";

            //Create list of AccountNumbers
            List<int> accountNumbers = new List<int>();

            if (ValidateInput(input, ref accountNumber))
            {
                //Call method to create list of Account number.
                CreateListOfAccountNumbers(fileName, ref accountNumbers);

                //Check if input matches active account numbers and return message.
                if (ValidAccountNumber(accountNumber, accountNumbers))
                {
                    MessageBox.Show("Input is a valid account number.");
                }
                else
                {
                    MessageBox.Show("Input is not a valid account number.");
                }
            }
            else
            {
                MessageBox.Show("Enter a 7 digit account number");
            }
        }

        private bool ValidAccountNumber(int accountNumber, List<int> accountNumbers)
        {
            bool validation = false;
            foreach (int activeAccount in accountNumbers)
            {
                if (activeAccount == accountNumber)
                {
                    validation = true;
                }
            }

            return validation;
        }

        private void CreateListOfAccountNumbers(string fileName, ref List<int> AccountNumbers)
        {
            //Open ChargeAccountsList.txt File
            StreamReader InputFile = File.OpenText(fileName);

            //Read Account numbers from file and load into list as int.
            try
            {
                while (!InputFile.EndOfStream)
                {
                    AccountNumbers.Add(int.Parse(InputFile.ReadLine()));
                }
            }
            catch (Exception ex)
            {
                //Error Message.
                MessageBox.Show(ex.Message);
            }

            InputFile.Close();
        }

        private bool ValidateInput(string input, ref int accountNumber)
        {
            bool validation = false;
            if (input.Length == 7 && (int.TryParse(input, out accountNumber )))
            {
                validation = true;
            }

            return validation;
        }

               
    }
}
