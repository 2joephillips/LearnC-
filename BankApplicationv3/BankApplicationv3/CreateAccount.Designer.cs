namespace BankApplicationv3
{
    partial class CreateAccount
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
            this.grpbxSelectAccount = new System.Windows.Forms.GroupBox();
            this.rdBtCD = new System.Windows.Forms.RadioButton();
            this.rdBtSavings = new System.Windows.Forms.RadioButton();
            this.rdBtChecking = new System.Windows.Forms.RadioButton();
            this.btnCreateAccountSave = new System.Windows.Forms.Button();
            this.btnCreateAccountClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxFName = new System.Windows.Forms.TextBox();
            this.txtbxSSN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxZip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxMaturityDate = new System.Windows.Forms.TextBox();
            this.lblMaturityDate = new System.Windows.Forms.Label();
            this.txtbxRate = new System.Windows.Forms.TextBox();
            this.txtbxInitialBalance = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpbxSelectAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxSelectAccount
            // 
            this.grpbxSelectAccount.Controls.Add(this.rdBtCD);
            this.grpbxSelectAccount.Controls.Add(this.rdBtSavings);
            this.grpbxSelectAccount.Controls.Add(this.rdBtChecking);
            this.grpbxSelectAccount.Location = new System.Drawing.Point(14, 13);
            this.grpbxSelectAccount.Name = "grpbxSelectAccount";
            this.grpbxSelectAccount.Size = new System.Drawing.Size(133, 108);
            this.grpbxSelectAccount.TabIndex = 0;
            this.grpbxSelectAccount.TabStop = false;
            this.grpbxSelectAccount.Text = "Select Account Type";
            // 
            // rdBtCD
            // 
            this.rdBtCD.AutoSize = true;
            this.rdBtCD.Location = new System.Drawing.Point(7, 66);
            this.rdBtCD.Name = "rdBtCD";
            this.rdBtCD.Size = new System.Drawing.Size(40, 17);
            this.rdBtCD.TabIndex = 2;
            this.rdBtCD.TabStop = true;
            this.rdBtCD.Text = "CD";
            this.rdBtCD.UseVisualStyleBackColor = true;
            this.rdBtCD.CheckedChanged += new System.EventHandler(this.rdBtCD_CheckedChanged);
            // 
            // rdBtSavings
            // 
            this.rdBtSavings.AutoSize = true;
            this.rdBtSavings.Location = new System.Drawing.Point(7, 43);
            this.rdBtSavings.Name = "rdBtSavings";
            this.rdBtSavings.Size = new System.Drawing.Size(63, 17);
            this.rdBtSavings.TabIndex = 1;
            this.rdBtSavings.TabStop = true;
            this.rdBtSavings.Text = "Savings";
            this.rdBtSavings.UseVisualStyleBackColor = true;
            this.rdBtSavings.CheckedChanged += new System.EventHandler(this.rdBtSavings_CheckedChanged);
            // 
            // rdBtChecking
            // 
            this.rdBtChecking.AutoSize = true;
            this.rdBtChecking.Location = new System.Drawing.Point(7, 20);
            this.rdBtChecking.Name = "rdBtChecking";
            this.rdBtChecking.Size = new System.Drawing.Size(70, 17);
            this.rdBtChecking.TabIndex = 0;
            this.rdBtChecking.TabStop = true;
            this.rdBtChecking.Text = "Checking";
            this.rdBtChecking.UseVisualStyleBackColor = true;
            this.rdBtChecking.CheckedChanged += new System.EventHandler(this.rdBtChecking_CheckedChanged);
            // 
            // btnCreateAccountSave
            // 
            this.btnCreateAccountSave.Location = new System.Drawing.Point(267, 314);
            this.btnCreateAccountSave.Name = "btnCreateAccountSave";
            this.btnCreateAccountSave.Size = new System.Drawing.Size(83, 45);
            this.btnCreateAccountSave.TabIndex = 1;
            this.btnCreateAccountSave.Text = "Submit";
            this.btnCreateAccountSave.UseVisualStyleBackColor = true;
            this.btnCreateAccountSave.Click += new System.EventHandler(this.btnCreateAccountSave_Click);
            // 
            // btnCreateAccountClose
            // 
            this.btnCreateAccountClose.Location = new System.Drawing.Point(375, 314);
            this.btnCreateAccountClose.Name = "btnCreateAccountClose";
            this.btnCreateAccountClose.Size = new System.Drawing.Size(83, 45);
            this.btnCreateAccountClose.TabIndex = 2;
            this.btnCreateAccountClose.Text = "Exit";
            this.btnCreateAccountClose.UseVisualStyleBackColor = true;
            this.btnCreateAccountClose.Click += new System.EventHandler(this.btnCreateAccountClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account Number:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountNumber.Location = new System.Drawing.Point(250, 13);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(100, 23);
            this.lblAccountNumber.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name:";
            // 
            // txtbxLName
            // 
            this.txtbxLName.Location = new System.Drawing.Point(280, 79);
            this.txtbxLName.Name = "txtbxLName";
            this.txtbxLName.Size = new System.Drawing.Size(169, 20);
            this.txtbxLName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name:";
            // 
            // txtbxFName
            // 
            this.txtbxFName.Location = new System.Drawing.Point(150, 79);
            this.txtbxFName.Name = "txtbxFName";
            this.txtbxFName.Size = new System.Drawing.Size(100, 20);
            this.txtbxFName.TabIndex = 7;
            // 
            // txtbxSSN
            // 
            this.txtbxSSN.Location = new System.Drawing.Point(150, 118);
            this.txtbxSSN.Name = "txtbxSSN";
            this.txtbxSSN.Size = new System.Drawing.Size(300, 20);
            this.txtbxSSN.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Social Security Number:";
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(150, 157);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(300, 20);
            this.txtbxAddress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(259, 196);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(32, 20);
            this.txtState.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(150, 196);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "State:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "City:";
            // 
            // txtbxZip
            // 
            this.txtbxZip.Location = new System.Drawing.Point(299, 196);
            this.txtbxZip.Name = "txtbxZip";
            this.txtbxZip.Size = new System.Drawing.Size(150, 20);
            this.txtbxZip.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Zip:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(150, 235);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phone Number:";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(259, 235);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(190, 20);
            this.txtbxEmail.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Email Address:";
            // 
            // txtBxMaturityDate
            // 
            this.txtBxMaturityDate.Location = new System.Drawing.Point(299, 276);
            this.txtBxMaturityDate.Name = "txtBxMaturityDate";
            this.txtBxMaturityDate.Size = new System.Drawing.Size(150, 20);
            this.txtBxMaturityDate.TabIndex = 28;
            // 
            // lblMaturityDate
            // 
            this.lblMaturityDate.AutoSize = true;
            this.lblMaturityDate.Location = new System.Drawing.Point(296, 260);
            this.lblMaturityDate.Name = "lblMaturityDate";
            this.lblMaturityDate.Size = new System.Drawing.Size(73, 13);
            this.lblMaturityDate.TabIndex = 27;
            this.lblMaturityDate.Text = "Maturity Date:";
            // 
            // txtbxRate
            // 
            this.txtbxRate.Location = new System.Drawing.Point(259, 276);
            this.txtbxRate.Name = "txtbxRate";
            this.txtbxRate.Size = new System.Drawing.Size(32, 20);
            this.txtbxRate.TabIndex = 26;
            // 
            // txtbxInitialBalance
            // 
            this.txtbxInitialBalance.Location = new System.Drawing.Point(150, 276);
            this.txtbxInitialBalance.Name = "txtbxInitialBalance";
            this.txtbxInitialBalance.Size = new System.Drawing.Size(100, 20);
            this.txtbxInitialBalance.TabIndex = 25;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(256, 260);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(33, 13);
            this.lblRate.TabIndex = 24;
            this.lblRate.Text = "Rate:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Intial Balance:";
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 373);
            this.Controls.Add(this.txtBxMaturityDate);
            this.Controls.Add(this.lblMaturityDate);
            this.Controls.Add(this.txtbxRate);
            this.Controls.Add(this.txtbxInitialBalance);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbxZip);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxSSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxLName);
            this.Controls.Add(this.txtbxFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateAccountClose);
            this.Controls.Add(this.btnCreateAccountSave);
            this.Controls.Add(this.grpbxSelectAccount);
            this.Name = "CreateAccount";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.grpbxSelectAccount.ResumeLayout(false);
            this.grpbxSelectAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxSelectAccount;
        private System.Windows.Forms.RadioButton rdBtCD;
        private System.Windows.Forms.RadioButton rdBtSavings;
        private System.Windows.Forms.RadioButton rdBtChecking;
        private System.Windows.Forms.Button btnCreateAccountSave;
        private System.Windows.Forms.Button btnCreateAccountClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxFName;
        private System.Windows.Forms.TextBox txtbxSSN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxZip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxMaturityDate;
        private System.Windows.Forms.Label lblMaturityDate;
        private System.Windows.Forms.TextBox txtbxRate;
        private System.Windows.Forms.TextBox txtbxInitialBalance;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label14;
    }
}