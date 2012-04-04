namespace Employee_Class
{
    partial class frmEmployeeList
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
            this.lstbxEmployees = new System.Windows.Forms.ListBox();
            this.btnDisplayEmployees = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxEmployees
            // 
            this.lstbxEmployees.FormattingEnabled = true;
            this.lstbxEmployees.Location = new System.Drawing.Point(13, 13);
            this.lstbxEmployees.Name = "lstbxEmployees";
            this.lstbxEmployees.Size = new System.Drawing.Size(259, 134);
            this.lstbxEmployees.TabIndex = 0;
            
            // 
            // btnDisplayEmployees
            // 
            this.btnDisplayEmployees.Location = new System.Drawing.Point(13, 165);
            this.btnDisplayEmployees.Name = "btnDisplayEmployees";
            this.btnDisplayEmployees.Size = new System.Drawing.Size(75, 47);
            this.btnDisplayEmployees.TabIndex = 1;
            this.btnDisplayEmployees.Text = "Display Employee";
            this.btnDisplayEmployees.UseVisualStyleBackColor = true;
            this.btnDisplayEmployees.Click += new System.EventHandler(this.btnDisplayEmployees_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(103, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayEmployees);
            this.Controls.Add(this.lstbxEmployees);
            this.Name = "frmEmployeeList";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.frmEmployeeList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxEmployees;
        private System.Windows.Forms.Button btnDisplayEmployees;
        private System.Windows.Forms.Button btnExit;
    }
}

