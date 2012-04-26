namespace PerferredCustomer3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckMailingList = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateDiscount = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Customers Info to Calculate Perferred Customer Discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number:";
            // 
            // ckMailingList
            // 
            this.ckMailingList.AutoSize = true;
            this.ckMailingList.Location = new System.Drawing.Point(236, 36);
            this.ckMailingList.Name = "ckMailingList";
            this.ckMailingList.Size = new System.Drawing.Size(78, 17);
            this.ckMailingList.TabIndex = 4;
            this.ckMailingList.Text = "Mailing List";
            this.ckMailingList.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(64, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(10, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = " ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(87, 37);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(87, 60);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(87, 87);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(87, 113);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 20);
            this.txtSales.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Sales:";
            // 
            // CalculateDiscount
            // 
            this.CalculateDiscount.Location = new System.Drawing.Point(15, 170);
            this.CalculateDiscount.Name = "CalculateDiscount";
            this.CalculateDiscount.Size = new System.Drawing.Size(75, 36);
            this.CalculateDiscount.TabIndex = 11;
            this.CalculateDiscount.Text = "Calculate Discount";
            this.CalculateDiscount.UseVisualStyleBackColor = true;
            this.CalculateDiscount.Click += new System.EventHandler(this.CalculateDiscount_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(96, 170);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 36);
            this.Close.TabIndex = 12;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 218);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.CalculateDiscount);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ckMailingList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Perferred Customer Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckMailingList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateDiscount;
        private System.Windows.Forms.Button Close;
    }
}

