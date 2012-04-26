namespace PerferredCustomerv2
{
    partial class Sales
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create New Customer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstCustomers
            // 
            this.lstCustomers.Location = new System.Drawing.Point(13, 82);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(600, 188);
            this.lstCustomers.TabIndex = 1;
            this.lstCustomers.UseCompatibleStateImageBehavior = false;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 374);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.button1);
            this.Name = "Sales";
            this.Text = "Perferred Customer Discount";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstCustomers;
    }
}

