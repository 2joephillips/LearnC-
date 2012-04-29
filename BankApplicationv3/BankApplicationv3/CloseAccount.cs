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
            txtbxAddress.Text = account.Customer.StAddr.ToString();
            txtbxEmail.Text = account.Customer.Email.ToString();
        }

        private void btnCreateAccountClose_Click(object sender, EventArgs e)
        {
            //Close from
            this.Close();
        }


    }
}
