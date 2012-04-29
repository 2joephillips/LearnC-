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
                    int transferAmount = int.Parse(txtbxTransferAmount.Text);
                    //UPdate From Account
                    account = accounts.Single(s => s.AccountId.ToString() == cmbxAccountFrom.SelectedValue.ToString());
                    account.Balance -= transferAmount;
                    accounts.RemoveAll(x => x.AccountId.ToString() == cmbxAccountFrom.SelectedValue.ToString());
                    accounts.Add(account);
                    txtbxBalanceFromAccount.Text = account.Balance.ToString();

                    //Update To Account
                    account = accounts.Single(s => s.AccountId.ToString() == cmbxToAccount.SelectedValue.ToString());
                    account.Balance -= transferAmount;
                    accounts.RemoveAll(x => x.AccountId.ToString() == cmbxToAccount.SelectedValue.ToString());
                    accounts.Add(account);
                    txtbxToBalance.Text = account.Balance.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    txtbxTransferAmount.Clear();
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

       }
}
