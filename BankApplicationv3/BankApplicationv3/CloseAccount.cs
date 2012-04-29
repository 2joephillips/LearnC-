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
        //List for Serialized data
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

        /// <summary>
        /// Find a account within the list 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            //Check for number to be entered.
            if (!string.IsNullOrEmpty(txtbxAccountNumber.Text))
            {
                try
                {
                    //find account within the list of accounts
                    account = accounts.Single(s => s.AccountId == int.Parse(txtbxAccountNumber.Text));
                    //Enter account data into form
                    FillinForm(account);
                }
                    //Error Handling
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtbxAccountNumber.Clear();
                    txtbxAccountNumber.Focus();
                }
                   
            }
                //Handle Error if nothing entered.
            else
            {
                MessageBox.Show("Please, Enter a Account Number.");
            }
        }
        /// <summary>
        /// Fill in the form with information from a single account.
        /// </summary>
        /// <param name="account"></param>
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
            //Format the form based on the type of account.
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

        /// <summary>
        /// Close Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAccountClose_Click(object sender, EventArgs e)
        {
            //Close from
            this.Close();
        }

        /// <summary>
        /// Remove the Account from List of accounts.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateAccountSave_Click(object sender, EventArgs e)
        {
            //Check for Number entered.
            if (!string.IsNullOrEmpty(txtbxAccountNumber.Text))
            {
                try
                {
                    
                    int accountId = int.Parse(txtbxAccountNumber.Text);
                    //Remove account.
                    accounts.RemoveAll(x => x.AccountId == accountId);

                    // Save list of accounts to Text file.
                    ObjectToSerialize objectToSerialize = new ObjectToSerialize();
                    objectToSerialize.Accounts = accounts;
                    Serializer serializer = new Serializer();
                    serializer.SerializeObject("outputFile.txt", objectToSerialize);

                    //Close Form.
                    this.Close();
                }
                    //Error Handling
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtbxAccountNumber.Clear();
                    txtbxAccountNumber.Focus();
                    ClearFrom();
                }

            }
            else
                //Error Handling
            {
                MessageBox.Show("Please, Enter a Account Number.");
            }
        }

        //Clear Form 
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
