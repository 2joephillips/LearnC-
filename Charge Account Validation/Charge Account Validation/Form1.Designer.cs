namespace Charge_Account_Validation
{
    partial class chargeAccountValidation
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtbxChargeAccount = new System.Windows.Forms.TextBox();
            this.btnValidateAccountNumber = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(36, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(179, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Enter 7 digit charge account number";
            // 
            // txtbxChargeAccount
            // 
            this.txtbxChargeAccount.Location = new System.Drawing.Point(47, 50);
            this.txtbxChargeAccount.Name = "txtbxChargeAccount";
            this.txtbxChargeAccount.Size = new System.Drawing.Size(100, 20);
            this.txtbxChargeAccount.TabIndex = 1;
            // 
            // btnValidateAccountNumber
            // 
            this.btnValidateAccountNumber.Location = new System.Drawing.Point(39, 89);
            this.btnValidateAccountNumber.Name = "btnValidateAccountNumber";
            this.btnValidateAccountNumber.Size = new System.Drawing.Size(75, 23);
            this.btnValidateAccountNumber.TabIndex = 2;
            this.btnValidateAccountNumber.Text = "Validate";
            this.btnValidateAccountNumber.UseVisualStyleBackColor = true;
            this.btnValidateAccountNumber.Click += new System.EventHandler(this.btnValidateAccountNumber_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(146, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chargeAccountValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 136);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnValidateAccountNumber);
            this.Controls.Add(this.txtbxChargeAccount);
            this.Controls.Add(this.lbl);
            this.Name = "chargeAccountValidation";
            this.Text = "Charge Account Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtbxChargeAccount;
        private System.Windows.Forms.Button btnValidateAccountNumber;
        private System.Windows.Forms.Button btnClose;
    }
}

