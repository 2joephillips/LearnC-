namespace Time_Zone
{
    partial class frmTimeZone
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
            this.lstbxCity = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.brnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a city and I will give you the time zone.";
            // 
            // lstbxCity
            // 
            this.lstbxCity.FormattingEnabled = true;
            this.lstbxCity.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "New York",
            "San Francisco"});
            this.lstbxCity.Location = new System.Drawing.Point(70, 40);
            this.lstbxCity.Name = "lstbxCity";
            this.lstbxCity.Size = new System.Drawing.Size(120, 95);
            this.lstbxCity.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Zone:";
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeZone.Location = new System.Drawing.Point(113, 155);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(100, 23);
            this.lblTimeZone.TabIndex = 3;
            // 
            // btnOkay
            // 
            this.btnOkay.AllowDrop = true;
            this.btnOkay.Location = new System.Drawing.Point(41, 205);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 23);
            this.btnOkay.TabIndex = 4;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // brnExit
            // 
            this.brnExit.Location = new System.Drawing.Point(128, 205);
            this.brnExit.Name = "brnExit";
            this.brnExit.Size = new System.Drawing.Size(75, 23);
            this.brnExit.TabIndex = 5;
            this.brnExit.Text = "Exit";
            this.brnExit.UseVisualStyleBackColor = true;
            this.brnExit.Click += new System.EventHandler(this.brnExit_Click);
            // 
            // frmTimeZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 246);
            this.Controls.Add(this.brnExit);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.lblTimeZone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstbxCity);
            this.Controls.Add(this.label1);
            this.Name = "frmTimeZone";
            this.Text = "Time Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbxCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeZone;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button brnExit;
    }
}

