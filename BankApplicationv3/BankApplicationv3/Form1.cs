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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* This section was used to create a first set of data for the banking Application. 
             * Create List of Accounts
            List<Account> accounts = new List<Account>();
             * Create individual accounts
            Account account = new Account() { AccountId = 1, Type = "Checking", Status = "Open", Balance = 2000, Rate = 0, Maturity = null, Customer = new Customer() { SSN = "123456789", FName = "Joseph", LName = "Phillips", StAddr = "1234 Anywhere St", City = "Birmingham", State = "AL", Zip = "12345", Phone = "2345678", Email = null } };
            Account account1 = new Account() { AccountId = 2, Type = "Savings", Status = "Open", Balance = 5000, Rate = 0.6m, Maturity = null, Customer = new Customer() { SSN = "123456789", FName = "Joseph", LName = "Phillips", StAddr = "1234 Anywhere St", City = "Birmingham", State = "AL", Zip = "12345", Phone = "2345678", Email = null } };
            Account account2 = new Account() { AccountId = 3, Type = "CD", Status = "Open", Balance = 2000, Rate = 0.6m, Maturity = "1/1/2015", Customer = new Customer() { SSN = "123456789", FName = "Joseph", LName = "Phillips", StAddr = "1234 Anywhere St", City = "Birmingham", State = "AL", Zip = "12345", Phone = "2345678", Email = null } };
            Account account3 = new Account() { AccountId = 4, Type = "Checking", Status = "Open", Balance = 2000, Rate = 0, Maturity = null, Customer = new Customer() { SSN = "987654321", FName = "Finn", LName = "Jack", StAddr = "1234 My St", City = "Birmingham", State = "AL", Zip = "12345", Phone = "9876554", Email = "finnjack@gmail.com" } };
            
             *Assign Individaul accounts to List of Accounts 
            accounts.Add(account);
            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);

            //save the accounts list to a file
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            objectToSerialize.Accounts = accounts;
            Serializer serializer = new Serializer();
            serializer.SerializeObject("outputFile.txt", objectToSerialize);
            */
            //Pull Data from Textfile.
            
       }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //Open Create Account Form
            CreateAccount frmCreateAccount = new CreateAccount();
            frmCreateAccount.Visible = true;

        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            CloseAccount frmCloseAccount = new CloseAccount();
            frmCloseAccount.Visible = true;
        }
    }
}
