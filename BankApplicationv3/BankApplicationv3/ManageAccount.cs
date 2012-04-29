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
    public partial class ManageAccount : Form
    {
        public List<Account> accounts = new List<Account>();
        public Account account;
        public ManageAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAccountClose_Click(object sender, EventArgs e)
        {
            //Close Form.
            this.Close();
        }

        //Find Account within accounts.
        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxAccountNumber.Text))
            {
                try
                {
                    account = accounts.Single(s => s.AccountId == int.Parse(txtbxAccountNumber.Text));
                    switch (account.Type)
                    {
                        case "Checking":
                            rdBtChecking.Checked = true;
                            break;

                        case "Savings":
                            rdBtSavings.Checked = true;
                            break;
                        case "CD":
                            rdBtCD.Checked = true;
                            break;
                        default:
                            rdBtChecking.Checked = true;
                            break;
                    }
                    FillinForm(account);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtbxAccountNumber.Clear();
                    txtbxAccountNumber.Focus();
                }

            }
            else
            {
                MessageBox.Show("Please, Enter a Account Number.");
            }

        }
        // Pull data.
        private void ManageAccount_Load(object sender, EventArgs e)
        {
            //Pull data from txt file.
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            Serializer serializer = new Serializer();
            objectToSerialize = serializer.DeSerializeObject("outputFile.txt");
            accounts = objectToSerialize.Accounts;
        }
        //Format form and fill data account. 
        private void FillinForm(Account account)
        {
            txtbxFName.Text = account.Customer.FName.ToString();
            txtbxLName.Text = account.Customer.LName.ToString();
            txtbxAddress.Text = account.Customer.StAddr.ToString();
            txtCity.Text = account.Customer.City.ToString();
            txtState.Text = account.Customer.State.ToString();
            txtbxZip.Text = account.Customer.Zip.ToString();
            txtPhoneNumber.Text = account.Customer.Phone.ToString();
            txtbxEmail.Text = account.Customer.Email.ToString();
            txtbxInitialBalance.Text = account.Balance.ToString();
            txtbxSSN.Text = account.Customer.SSN.ToString();
            txtbxRate.Text = account.Rate.ToString();
            txtBxMaturityDate.Text = account.Maturity.ToString();

          
        }
        //Save changes to text file. 
        private void btnCreateAccountSave_Click(object sender, EventArgs e)
        {
            int accountId = int.Parse(txtbxAccountNumber.Text);
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

            //save depending on type of account. 
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
            //remove account 
            accounts.RemoveAll(x => x.AccountId == accountId);
            //readd acount. 
            accounts.Add(account);

            //save the accounts list to a file
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            objectToSerialize.Accounts = accounts;
            Serializer serializer = new Serializer();
            serializer.SerializeObject("outputFile.txt", objectToSerialize);

            this.Close();
        }

        //Format for Checking account policies. 
        private void rdBtChecking_CheckedChanged(object sender, EventArgs e)
        {
            this.lblMaturityDate.Visible = false;
            this.lblRate.Visible = false;
            this.txtbxRate.Visible = false;
            this.txtBxMaturityDate.Visible = false;
        }

        //Format for savincgs account policies. 
        private void rdBtSavings_CheckedChanged(object sender, EventArgs e)
        {
            this.lblMaturityDate.Visible = false;
            this.lblRate.Visible = true;
            this.txtbxRate.Visible = true;
            this.txtBxMaturityDate.Visible = false;
        }

        //Format for cd account policies. 
        private void rdBtCD_CheckedChanged(object sender, EventArgs e)
        {
            this.lblMaturityDate.Visible = true;
            this.lblRate.Visible = true;
            this.txtbxRate.Visible = true;
            this.txtBxMaturityDate.Visible = true;
        }

        //Handle type of accounts. 
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

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAccount frmCreateAccount = new CreateAccount();
            frmCreateAccount.Visible = true;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseAccount frmCloseAccount = new CloseAccount();
            frmCloseAccount.Visible = true;
            this.Close();
        }

    }
}
