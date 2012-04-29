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
    public partial class ConductTransaction : Form
    {
        public List<Account> accounts = new List<Account>();
        public Account account;
        public ConductTransaction()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Pull data from text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConductTransaction_Load(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = false;
            //Pull data from txt file.
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            Serializer serializer = new Serializer();
            objectToSerialize = serializer.DeSerializeObject("outputFile.txt");
            accounts = objectToSerialize.Accounts;
        }
        /// <summary>
        /// When closing form save data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            objectToSerialize.Accounts = accounts;
            Serializer serializer = new Serializer();
            serializer.SerializeObject("outputFile.txt", objectToSerialize);
            
            //Close Form
            this.Close();


        }

        //Format for for Transfer checked.
        private void rdbtnTransfer_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = false;
            this.pnlTransfer.Visible = true;
        }
        //Format for for Deposit checked.
        private void rdbtnDeposit_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = true;
            this.pnlTransfer.Visible = false;
            this.lblDeposit.Visible = true;
            this.txtbxDeposit.Visible = true;
            this.txtbxWithdrawl.Visible = false;
            this.lblWithdrawl.Visible = false;
        }
        //Format for for withdrawl checked.
        private void rdbtnWithdrawl_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = true;
            this.pnlTransfer.Visible = false;
            this.lblDeposit.Visible = false;
            this.txtbxDeposit.Visible = false;
            this.txtbxWithdrawl.Visible = true;
            this.lblWithdrawl.Visible = true;
        }
        //Format for for AddInterest checked.
        private void rdbtAddInterest_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = true;
            this.pnlTransfer.Visible = false;
            this.lblDeposit.Visible = false;
            this.txtbxDeposit.Visible = false;
            this.txtbxWithdrawl.Visible = false;
            this.lblWithdrawl.Visible = false;
        }

        //Enter combox calculate accounts
        private void cmbxAccountFrom_Enter(object sender, EventArgs e)
        {
            cmbxAccountFrom.DataSource = accounts.ToArray();
            cmbxAccountFrom.DisplayMember = "AccountId";
            cmbxAccountFrom.ValueMember = "AccountId";
        }
        /// <summary>
        /// Handle the options for form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ///Transfer option checked.
            if (rdbtnTransfer.Checked)
            {
                try
                {
                    decimal transferAmount = decimal.Parse(txtbxTransferAmount.Text);
                    //UPdate From Account
                    account = accounts.Single(s => s.AccountId.ToString() == cmbxAccountFrom.SelectedValue.ToString());
                    if (account.Balance > transferAmount)
                    {
                        account.Balance -= transferAmount;
                        accounts.RemoveAll(x => x.AccountId.ToString() == cmbxAccountFrom.SelectedValue.ToString());
                        accounts.Add(account);
                        txtbxBalanceFromAccount.Text = account.Balance.ToString();

                        //Update To Account
                        account = accounts.Single(s => s.AccountId.ToString() == cmbxToAccount.SelectedValue.ToString());
                        account.Balance += transferAmount;
                        accounts.RemoveAll(x => x.AccountId.ToString() == cmbxToAccount.SelectedValue.ToString());
                        accounts.Add(account);
                        txtbxToBalance.Text = account.Balance.ToString();

                        txtbxTransferAmount.Clear();

                    }
                    else
                    {
                        MessageBox.Show("NSF");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    txtbxTransferAmount.Clear();
                }
            }
                // Handle Deposits 
            else if (rdbtnDeposit.Checked)
            {
                try
                {
                    decimal deposit = decimal.Parse(txtbxDeposit.Text);
                    account = accounts.Single(s => s.AccountId.ToString() == cmboxAccountNumbers.SelectedValue.ToString());
                    string intialAmount = account.Balance.ToString("c");
                    account.Balance += deposit;
                    string newAmount = account.Balance.ToString("c");
                    accounts.RemoveAll(x => x.AccountId.ToString() == cmboxAccountNumbers.SelectedValue.ToString());
                    accounts.Add(account);
                    MessageBox.Show("Deposited " + deposit.ToString("c") + " to your account raising your balance from " + intialAmount + " to " + newAmount + ".");
                    this.txtbxDeposit.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                //Handle Withdrawls. 
            else if (rdbtnWithdrawl.Checked)
            {
                 try
                {
                    decimal withdrawl = decimal.Parse(txtbxWithdrawl.Text);
                    account = accounts.Single(s => s.AccountId.ToString() == cmboxAccountNumbers.SelectedValue.ToString());
                    if (account.Balance > withdrawl)
                    {
                        string intialAmount = account.Balance.ToString("c");
                        account.Balance -= withdrawl;
                        string newAmount = account.Balance.ToString("c");
                        accounts.RemoveAll(x => x.AccountId.ToString() == cmboxAccountNumbers.SelectedValue.ToString()); 
                        accounts.Add(account);
                        MessageBox.Show("Withdrawled " + withdrawl.ToString("c") + " to your account raising your balance from " + intialAmount + " to " + newAmount + ".");
                        this.txtbxWithdrawl.Clear();
                    }
                    else
                    {
                        MessageBox.Show("NSF");
                        txtbxWithdrawl.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //Enter combox calculate accounts
        private void cmbxToAccount_Enter(object sender, EventArgs e)
        {
        
            var result = from p in accounts where p.AccountId.ToString() != cmbxAccountFrom.SelectedValue.ToString() select p;
            cmbxToAccount.DataSource = result.ToArray();
            cmbxToAccount.DisplayMember = "AccountId";
            cmbxToAccount.ValueMember = "AccountId";
        }
        //Enter combox calculate accounts
        private void cmbxAccountFrom_Leave(object sender, EventArgs e)
        {
            account = accounts.Single(s => s.AccountId.ToString() == cmbxAccountFrom.SelectedValue.ToString());
            txtbxBalanceFromAccount.Text = account.Balance.ToString();
        }
        //Enter combox calculate accounts
        private void cmbxToAccount_Leave(object sender, EventArgs e)
        {
            account = accounts.Single(s => s.AccountId.ToString() == cmbxToAccount.SelectedValue.ToString());
            txtbxToBalance.Text = account.Balance.ToString();
        }
        //Enter combox calculate accounts
        private void cmboxAccountNumbers_Enter(object sender, EventArgs e)
        {
            cmboxAccountNumbers.DataSource = accounts.ToArray();
            cmboxAccountNumbers.DisplayMember = "AccountId";
            cmboxAccountNumbers.ValueMember = "AccountId";
        }
        //Cear from.
        private void Clearall()
        {
            cmboxAccountNumbers.Text = "";
            cmbxAccountFrom.Text = "";
            cmbxToAccount.Text = "";
            txtbxBalanceFromAccount.Clear();
            txtbxDeposit.Clear();
            txtbxToBalance.Clear();
            txtbxTransferAmount.Clear();
            txtbxWithdrawl.Clear();
        }

        private void btnAnotherTransaction_Click(object sender, EventArgs e)
        {
            Clearall();
            this.Refresh();
        }

       }
}
