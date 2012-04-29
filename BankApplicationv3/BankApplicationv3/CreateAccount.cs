using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankApplicationv3
{
    public partial class CreateAccount : Form
    {
        public List<Account> accounts = new List<Account>();
        public Account account;
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAccountClose_Click(object sender, EventArgs e)
        {
           
            //Close Form
            this.Close();
        }

        //Load Accounts into Form
        private void CreateAccount_Load(object sender, EventArgs e)
        {


            //Calculate the next Account number
            lblAccountNumber.Text = NextAccountNumber();

            //Pull data from txt file.
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            Serializer serializer = new Serializer();
            objectToSerialize = serializer.DeSerializeObject("outputFile.txt");
            accounts = objectToSerialize.Accounts;
            //Calculate the next Account number
            lblAccountNumber.Text = NextAccountNumber();
        }

        //Calculate the next Account Number.
        private string NextAccountNumber()
        {
            try
            {
            int maxAccountNumber = (from p in accounts select p.AccountId).Max();
            int nextAccountnumber;
            nextAccountnumber = maxAccountNumber + 1;
            return nextAccountnumber.ToString();
            }
            catch (Exception)
            {
                int nextAccountnumber = 1;
                return nextAccountnumber.ToString();
            }   
        }

        //Checking Radiobutton Selected and items for Rate and Maturity Date removed.
        private void rdBtChecking_CheckedChanged(object sender, EventArgs e)
        {
            this.lblMaturityDate.Visible = false;
            this.lblRate.Visible = false;
            this.txtbxRate.Visible = false;
            this.txtBxMaturityDate.Visible = false;
        }

        //Savings Radiobutton Selected and items for Rate Shown and Maturity Date removed.
        private void rdBtSavings_CheckedChanged(object sender, EventArgs e)
        {
            this.lblMaturityDate.Visible = false;
            this.lblRate.Visible = true;
            this.txtbxRate.Visible = true;
            this.txtBxMaturityDate.Visible = false;
        }

        //CD Radiobutton Selected and items for Rate and Maturity Date are shown.
        private void rdBtCD_CheckedChanged(object sender, EventArgs e)
        {
            this.lblMaturityDate.Visible = true;
            this.lblRate.Visible = true;
            this.txtbxRate.Visible = true;
            this.txtBxMaturityDate.Visible = true;
        }

        private void btnCreateAccountSave_Click(object sender, EventArgs e)
        {

            try
            {
                int accountId = int.Parse(lblAccountNumber.Text);
                string type = TypeOfAccount();
                string status = "Open";
                decimal balance = decimal.Parse(txtbxInitialBalance.Text);
                decimal rate;
                string maturitydate = txtBxMaturityDate.Text;
                Customer customer = new Customer();
                customer.SSN = txtbxSSN.Text;
                customer.FName = txtbxFName.Text;
                customer.LName = txtbxLName.Text;
                customer.StAddr = txtbxAddress.Text;
                customer.City = txtCity.Text;
                customer.State = txtState.Text;
                customer.Zip = txtbxZip.Text;
                customer.Phone = txtPhoneNumber.Text;
                customer.Email = txtbxEmail.Text;

                bool result = decimal.TryParse(txtbxRate.Text, out rate);
                if (result)
                {
                    account = new Account()
                    {
                        AccountId = accountId,
                        Type = type,
                        Status = status,
                        Balance = balance,
                        Customer = customer,
                        Rate = rate,
                        Maturity = maturitydate
                    };
                }
                else
                {
                    account = new Account()
                    {
                        AccountId = accountId,
                        Type = type,
                        Status = status,
                        Balance = balance,
                        Customer = customer,
                        Rate = 0,
                        Maturity = maturitydate
                    };
                }

                accounts.Add(account);

                //save the accounts list to a file
                ObjectToSerialize objectToSerialize = new ObjectToSerialize();
                objectToSerialize.Accounts = accounts;
                Serializer serializer = new Serializer();
                serializer.SerializeObject("outputFile.txt", objectToSerialize);

                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("All boxes should be filled out.");
            }
                  
        }

        private string TypeOfAccount()
        {
            if (rdBtCD.Checked)
            {
                return "CD";
            }
            else if (rdBtSavings.Checked)
            {
                return "Savings";
            }
            else
            {
                return "Checking";
            }
        }


       
    }
}
