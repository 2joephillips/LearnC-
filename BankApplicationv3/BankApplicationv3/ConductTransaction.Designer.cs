namespace BankApplicationv3
{
    partial class ConductTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtAddInterest = new System.Windows.Forms.RadioButton();
            this.rdbtnWithdrawl = new System.Windows.Forms.RadioButton();
            this.rdbtnDeposit = new System.Windows.Forms.RadioButton();
            this.rdbtnTransfer = new System.Windows.Forms.RadioButton();
            this.pnlTransferDepositWithdrawl = new System.Windows.Forms.Panel();
            this.lblWithdrawl = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtbxWithdrawl = new System.Windows.Forms.TextBox();
            this.txtbxDeposit = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cmboxAccountNumbers = new System.Windows.Forms.ComboBox();
            this.lblBalanceFromAccount = new System.Windows.Forms.Label();
            this.txtbxBalanceFromAccount = new System.Windows.Forms.TextBox();
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxToBalance = new System.Windows.Forms.TextBox();
            this.lblTransferAmount = new System.Windows.Forms.Label();
            this.txtbxTransferAmount = new System.Windows.Forms.TextBox();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.cmbxToAccount = new System.Windows.Forms.ComboBox();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.cmbxAccountFrom = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAnotherTransaction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlTransferDepositWithdrawl.SuspendLayout();
            this.pnlTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtAddInterest);
            this.groupBox1.Controls.Add(this.rdbtnWithdrawl);
            this.groupBox1.Controls.Add(this.rdbtnDeposit);
            this.groupBox1.Controls.Add(this.rdbtnTransfer);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Type";
            // 
            // rdbtAddInterest
            // 
            this.rdbtAddInterest.AutoSize = true;
            this.rdbtAddInterest.Location = new System.Drawing.Point(19, 88);
            this.rdbtAddInterest.Name = "rdbtAddInterest";
            this.rdbtAddInterest.Size = new System.Drawing.Size(76, 17);
            this.rdbtAddInterest.TabIndex = 3;
            this.rdbtAddInterest.TabStop = true;
            this.rdbtAddInterest.Text = "Add Intrest";
            this.rdbtAddInterest.UseVisualStyleBackColor = true;
            this.rdbtAddInterest.CheckedChanged += new System.EventHandler(this.rdbtAddInterest_CheckedChanged);
            // 
            // rdbtnWithdrawl
            // 
            this.rdbtnWithdrawl.AutoSize = true;
            this.rdbtnWithdrawl.Location = new System.Drawing.Point(19, 65);
            this.rdbtnWithdrawl.Name = "rdbtnWithdrawl";
            this.rdbtnWithdrawl.Size = new System.Drawing.Size(72, 17);
            this.rdbtnWithdrawl.TabIndex = 2;
            this.rdbtnWithdrawl.TabStop = true;
            this.rdbtnWithdrawl.Text = "Withdrawl";
            this.rdbtnWithdrawl.UseVisualStyleBackColor = true;
            this.rdbtnWithdrawl.CheckedChanged += new System.EventHandler(this.rdbtnWithdrawl_CheckedChanged);
            // 
            // rdbtnDeposit
            // 
            this.rdbtnDeposit.AutoSize = true;
            this.rdbtnDeposit.Location = new System.Drawing.Point(19, 42);
            this.rdbtnDeposit.Name = "rdbtnDeposit";
            this.rdbtnDeposit.Size = new System.Drawing.Size(61, 17);
            this.rdbtnDeposit.TabIndex = 1;
            this.rdbtnDeposit.TabStop = true;
            this.rdbtnDeposit.Text = "Deposit";
            this.rdbtnDeposit.UseVisualStyleBackColor = true;
            this.rdbtnDeposit.CheckedChanged += new System.EventHandler(this.rdbtnDeposit_CheckedChanged);
            // 
            // rdbtnTransfer
            // 
            this.rdbtnTransfer.AutoSize = true;
            this.rdbtnTransfer.Location = new System.Drawing.Point(19, 19);
            this.rdbtnTransfer.Name = "rdbtnTransfer";
            this.rdbtnTransfer.Size = new System.Drawing.Size(64, 17);
            this.rdbtnTransfer.TabIndex = 0;
            this.rdbtnTransfer.TabStop = true;
            this.rdbtnTransfer.Text = "Transfer";
            this.rdbtnTransfer.UseVisualStyleBackColor = true;
            this.rdbtnTransfer.CheckedChanged += new System.EventHandler(this.rdbtnTransfer_CheckedChanged);
            // 
            // pnlTransferDepositWithdrawl
            // 
            this.pnlTransferDepositWithdrawl.Controls.Add(this.lblWithdrawl);
            this.pnlTransferDepositWithdrawl.Controls.Add(this.lblDeposit);
            this.pnlTransferDepositWithdrawl.Controls.Add(this.txtbxWithdrawl);
            this.pnlTransferDepositWithdrawl.Controls.Add(this.txtbxDeposit);
            this.pnlTransferDepositWithdrawl.Controls.Add(this.lblAccount);
            this.pnlTransferDepositWithdrawl.Controls.Add(this.cmboxAccountNumbers);
            this.pnlTransferDepositWithdrawl.Location = new System.Drawing.Point(169, 13);
            this.pnlTransferDepositWithdrawl.Name = "pnlTransferDepositWithdrawl";
            this.pnlTransferDepositWithdrawl.Size = new System.Drawing.Size(261, 190);
            this.pnlTransferDepositWithdrawl.TabIndex = 1;
            // 
            // lblWithdrawl
            // 
            this.lblWithdrawl.AutoSize = true;
            this.lblWithdrawl.Location = new System.Drawing.Point(131, 126);
            this.lblWithdrawl.Name = "lblWithdrawl";
            this.lblWithdrawl.Size = new System.Drawing.Size(54, 13);
            this.lblWithdrawl.TabIndex = 5;
            this.lblWithdrawl.Text = "Withdrawl";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(16, 126);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(43, 13);
            this.lblDeposit.TabIndex = 4;
            this.lblDeposit.Text = "Deposit";
            // 
            // txtbxWithdrawl
            // 
            this.txtbxWithdrawl.Location = new System.Drawing.Point(134, 142);
            this.txtbxWithdrawl.Name = "txtbxWithdrawl";
            this.txtbxWithdrawl.Size = new System.Drawing.Size(100, 20);
            this.txtbxWithdrawl.TabIndex = 3;
            // 
            // txtbxDeposit
            // 
            this.txtbxDeposit.Location = new System.Drawing.Point(19, 142);
            this.txtbxDeposit.Name = "txtbxDeposit";
            this.txtbxDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtbxDeposit.TabIndex = 2;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(72, 10);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "Account";
            // 
            // cmboxAccountNumbers
            // 
            this.cmboxAccountNumbers.FormattingEnabled = true;
            this.cmboxAccountNumbers.Location = new System.Drawing.Point(72, 29);
            this.cmboxAccountNumbers.Name = "cmboxAccountNumbers";
            this.cmboxAccountNumbers.Size = new System.Drawing.Size(121, 21);
            this.cmboxAccountNumbers.TabIndex = 0;
            this.cmboxAccountNumbers.Enter += new System.EventHandler(this.cmboxAccountNumbers_Enter);
            // 
            // lblBalanceFromAccount
            // 
            this.lblBalanceFromAccount.AutoSize = true;
            this.lblBalanceFromAccount.Location = new System.Drawing.Point(16, 52);
            this.lblBalanceFromAccount.Name = "lblBalanceFromAccount";
            this.lblBalanceFromAccount.Size = new System.Drawing.Size(126, 13);
            this.lblBalanceFromAccount.TabIndex = 8;
            this.lblBalanceFromAccount.Text = "Balance in From Account";
            // 
            // txtbxBalanceFromAccount
            // 
            this.txtbxBalanceFromAccount.Location = new System.Drawing.Point(19, 68);
            this.txtbxBalanceFromAccount.Name = "txtbxBalanceFromAccount";
            this.txtbxBalanceFromAccount.Size = new System.Drawing.Size(100, 20);
            this.txtbxBalanceFromAccount.TabIndex = 7;
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.Controls.Add(this.label1);
            this.pnlTransfer.Controls.Add(this.txtbxToBalance);
            this.pnlTransfer.Controls.Add(this.lblBalanceFromAccount);
            this.pnlTransfer.Controls.Add(this.lblTransferAmount);
            this.pnlTransfer.Controls.Add(this.txtbxBalanceFromAccount);
            this.pnlTransfer.Controls.Add(this.txtbxTransferAmount);
            this.pnlTransfer.Controls.Add(this.lblToAccount);
            this.pnlTransfer.Controls.Add(this.cmbxToAccount);
            this.pnlTransfer.Controls.Add(this.lblFromAccount);
            this.pnlTransfer.Controls.Add(this.cmbxAccountFrom);
            this.pnlTransfer.Location = new System.Drawing.Point(13, 209);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(417, 158);
            this.pnlTransfer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Balance in To Account";
            // 
            // txtbxToBalance
            // 
            this.txtbxToBalance.Location = new System.Drawing.Point(19, 107);
            this.txtbxToBalance.Name = "txtbxToBalance";
            this.txtbxToBalance.Size = new System.Drawing.Size(100, 20);
            this.txtbxToBalance.TabIndex = 9;
            // 
            // lblTransferAmount
            // 
            this.lblTransferAmount.AutoSize = true;
            this.lblTransferAmount.Location = new System.Drawing.Point(16, 13);
            this.lblTransferAmount.Name = "lblTransferAmount";
            this.lblTransferAmount.Size = new System.Drawing.Size(85, 13);
            this.lblTransferAmount.TabIndex = 6;
            this.lblTransferAmount.Text = "Transfer Amount";
            // 
            // txtbxTransferAmount
            // 
            this.txtbxTransferAmount.Location = new System.Drawing.Point(19, 29);
            this.txtbxTransferAmount.Name = "txtbxTransferAmount";
            this.txtbxTransferAmount.Size = new System.Drawing.Size(100, 20);
            this.txtbxTransferAmount.TabIndex = 5;
            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Location = new System.Drawing.Point(275, 13);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(63, 13);
            this.lblToAccount.TabIndex = 3;
            this.lblToAccount.Text = "To Account";
            // 
            // cmbxToAccount
            // 
            this.cmbxToAccount.FormattingEnabled = true;
            this.cmbxToAccount.Location = new System.Drawing.Point(278, 29);
            this.cmbxToAccount.Name = "cmbxToAccount";
            this.cmbxToAccount.Size = new System.Drawing.Size(121, 21);
            this.cmbxToAccount.TabIndex = 2;
            this.cmbxToAccount.Enter += new System.EventHandler(this.cmbxToAccount_Enter);
            this.cmbxToAccount.Leave += new System.EventHandler(this.cmbxToAccount_Leave);
            // 
            // lblFromAccount
            // 
            this.lblFromAccount.AutoSize = true;
            this.lblFromAccount.Location = new System.Drawing.Point(149, 13);
            this.lblFromAccount.Name = "lblFromAccount";
            this.lblFromAccount.Size = new System.Drawing.Size(73, 13);
            this.lblFromAccount.TabIndex = 1;
            this.lblFromAccount.Text = "From Account";
            // 
            // cmbxAccountFrom
            // 
            this.cmbxAccountFrom.FormattingEnabled = true;
            this.cmbxAccountFrom.Location = new System.Drawing.Point(152, 29);
            this.cmbxAccountFrom.Name = "cmbxAccountFrom";
            this.cmbxAccountFrom.Size = new System.Drawing.Size(121, 21);
            this.cmbxAccountFrom.TabIndex = 0;
            this.cmbxAccountFrom.Enter += new System.EventHandler(this.cmbxAccountFrom_Enter);
            this.cmbxAccountFrom.Leave += new System.EventHandler(this.cmbxAccountFrom_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(76, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 41);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAnotherTransaction
            // 
            this.btnAnotherTransaction.Location = new System.Drawing.Point(169, 373);
            this.btnAnotherTransaction.Name = "btnAnotherTransaction";
            this.btnAnotherTransaction.Size = new System.Drawing.Size(80, 41);
            this.btnAnotherTransaction.TabIndex = 4;
            this.btnAnotherTransaction.Text = "Another Transaction";
            this.btnAnotherTransaction.UseVisualStyleBackColor = true;
            this.btnAnotherTransaction.Click += new System.EventHandler(this.btnAnotherTransaction_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(255, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 41);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ConductTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 422);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAnotherTransaction);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlTransfer);
            this.Controls.Add(this.pnlTransferDepositWithdrawl);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConductTransaction";
            this.Text = "Conduct Transaction";
            this.Load += new System.EventHandler(this.ConductTransaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTransferDepositWithdrawl.ResumeLayout(false);
            this.pnlTransferDepositWithdrawl.PerformLayout();
            this.pnlTransfer.ResumeLayout(false);
            this.pnlTransfer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtAddInterest;
        private System.Windows.Forms.RadioButton rdbtnWithdrawl;
        private System.Windows.Forms.RadioButton rdbtnDeposit;
        private System.Windows.Forms.RadioButton rdbtnTransfer;
        private System.Windows.Forms.Panel pnlTransferDepositWithdrawl;
        private System.Windows.Forms.Label lblWithdrawl;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtbxWithdrawl;
        private System.Windows.Forms.TextBox txtbxDeposit;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cmboxAccountNumbers;
        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.Label lblBalanceFromAccount;
        private System.Windows.Forms.TextBox txtbxBalanceFromAccount;
        private System.Windows.Forms.Label lblTransferAmount;
        private System.Windows.Forms.TextBox txtbxTransferAmount;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.ComboBox cmbxToAccount;
        private System.Windows.Forms.Label lblFromAccount;
        private System.Windows.Forms.ComboBox cmbxAccountFrom;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAnotherTransaction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxToBalance;
    }
}