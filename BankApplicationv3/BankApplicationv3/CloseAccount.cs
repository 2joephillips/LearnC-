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
    public partial class CloseAccount : Form
    {
        public List<Account> accounts = new List<Account>();
        public Account account;
        public CloseAccount()
        {
            InitializeComponent();
        }

        //Load Accounts into Form
        private void CloseAccount_Load(object sender, EventArgs e)
        {
            //Pull data from txt file.
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            Serializer serializer = new Serializer();
            objectToSerialize = serializer.DeSerializeObject("outputFile.txt");
            accounts = objectToSerialize.Accounts;
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxAccountNumber.Text))
            {
                try
                {
                    account = accounts.Single(s => s.AccountId == int.Parse(txtbxAccountNumber.Text));
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
            if (account.Type == "Savings")
            {
                this.lblMaturityDate.Visible = false;
                this.lblRate.Visible = true;
                this.txtbxRate.Visible = true;
                this.txtBxMaturityDate.Visible = false;
            }
            else if (account.Type == "CD")
            {
                this.lblMaturityDate.Visible = false;
                this.lblRate.Visible = true;
                this.txtbxRate.Visible = true;
                this.txtBxMaturityDate.Visible = false;
            }
            else
            {
                this.lblMaturityDate.Visible = false;
                this.lblRate.Visible = false;
                this.txtbxRate.Visible = false;
                this.txtBxMaturityDate.Visible = false;
            }
            txtbxRate.Text = account.Rate.ToString();
            txtBxMaturityDate.Text = account.Maturity.ToString();
        }

        private void btnCreateAccountClose_Click(object sender, EventArgs e)
        {
            //Close from
            this.Close();
        }

        private void btnCreateAccountSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbxAccountNumber.Text))
            {
                try
                {
                    int accountId = int.Parse(txtbxAccountNumber.Text);
                    accounts.RemoveAll(x => x.AccountId == accountId);

                    ObjectToSerialize objectToSerialize = new ObjectToSerialize();
                    objectToSerialize.Accounts = accounts;
                    Serializer serializer = new Serializer();
                    serializer.SerializeObject("outputFile.txt", objectToSerialize);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtbxAccountNumber.Clear();
                    txtbxAccountNumber.Focus();
                    ClearFrom();
                }

            }
            else
            {
                MessageBox.Show("Please, Enter a Account Number.");
            }
        }

        private void ClearFrom()
        {
            txtbxFName.Clear();
            txtbxLName.Clear();
            txtbxSSN.Clear();
            txtbxAddress.Clear();
            txtbxSSN.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtbxZip.Clear();
            txtPhoneNumber.Clear();
            txtbxEmail.Clear();
            txtbxInitialBalance.Clear();
            txtBxMaturityDate.Clear();
        }


    }
}
