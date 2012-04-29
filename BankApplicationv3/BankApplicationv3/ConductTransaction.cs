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

        private void ConductTransaction_Load(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = false;
            //Pull data from txt file.
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            Serializer serializer = new Serializer();
            objectToSerialize = serializer.DeSerializeObject("outputFile.txt");
            accounts = objectToSerialize.Accounts;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            ObjectToSerialize objectToSerialize = new ObjectToSerialize();
            objectToSerialize.Accounts = accounts;
            Serializer serializer = new Serializer();
            serializer.SerializeObject("outputFile.txt", objectToSerialize);
            
            //Close Form
            this.Close();


        }

        private void rdbtnTransfer_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = false;
            this.pnlTransfer.Visible = true;
        }

        private void rdbtnDeposit_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = true;
            this.pnlTransfer.Visible = false;
            this.lblDeposit.Visible = true;
            this.txtbxDeposit.Visible = true;
            this.txtbxWithdrawl.Visible = false;
            this.lblWithdrawl.Visible = false;
        }

        private void rdbtnWithdrawl_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = true;
            this.pnlTransfer.Visible = false;
            this.lblDeposit.Visible = false;
            this.txtbxDeposit.Visible = false;
            this.txtbxWithdrawl.Visible = true;
            this.lblWithdrawl.Visible = true;
        }

        private void rdbtAddInterest_CheckedChanged(object sender, EventArgs e)
        {
            this.pnlTransferDepositWithdrawl.Visible = true;
            this.pnlTransfer.Visible = false;
            this.lblDeposit.Visible = false;
            this.txtbxDeposit.Visible = false;
            this.txtbxWithdrawl.Visible = false;
            this.lblWithdrawl.Visible = false;
        }

        private void cmbxAccountFrom_Enter(object sender, EventArgs e)
        {
            cmbxAccountFrom.DataSource = accounts.ToArray();
            cmbxAccountFrom.DisplayMember = "AccountId";
            cmbxAccountFrom.ValueMember = "AccountId";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
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

        private void cmbxToAccount_Enter(object sender, EventArgs e)
        {
        
            var result = from p in accounts where p.AccountId.ToString() != cmbxAccountFrom.SelectedValue.ToString() select p;
            cmbxToAccount.DataSource = result.ToArray();
            cmbxToAccount.DisplayMember = "AccountId";
            cmbxToAccount.ValueMember = "AccountId";
        }

        private void cmbxAccountFrom_Leave(object sender, EventArgs e)
        {
            account = accounts.Single(s => s.AccountId.ToString() == cmbxAccountFrom.SelectedValue.ToString());
            txtbxBalanceFromAccount.Text = account.Balance.ToString();
        }

        private void cmbxToAccount_Leave(object sender, EventArgs e)
        {
            account = accounts.Single(s => s.AccountId.ToString() == cmbxToAccount.SelectedValue.ToString());
            txtbxToBalance.Text = account.Balance.ToString();
        }

        private void cmboxAccountNumbers_Enter(object sender, EventArgs e)
        {
            cmboxAccountNumbers.DataSource = accounts.ToArray();
            cmboxAccountNumbers.DisplayMember = "AccountId";
            cmboxAccountNumbers.ValueMember = "AccountId";
        }

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
