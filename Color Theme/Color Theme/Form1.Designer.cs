namespace Color_Theme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnBackToNormal = new System.Windows.Forms.RadioButton();
            this.rdbtnWhite = new System.Windows.Forms.RadioButton();
            this.rdbtnRed = new System.Windows.Forms.RadioButton();
            this.rdbtnYellow = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnBackToNormal);
            this.groupBox1.Controls.Add(this.rdbtnWhite);
            this.groupBox1.Controls.Add(this.rdbtnRed);
            this.groupBox1.Controls.Add(this.rdbtnYellow);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A Background Color";
            // 
            // rdbtnBackToNormal
            // 
            this.rdbtnBackToNormal.AutoSize = true;
            this.rdbtnBackToNormal.Checked = true;
            this.rdbtnBackToNormal.Location = new System.Drawing.Point(24, 98);
            this.rdbtnBackToNormal.Name = "rdbtnBackToNormal";
            this.rdbtnBackToNormal.Size = new System.Drawing.Size(98, 17);
            this.rdbtnBackToNormal.TabIndex = 0;
            this.rdbtnBackToNormal.TabStop = true;
            this.rdbtnBackToNormal.Text = "Back to Normal";
            this.rdbtnBackToNormal.UseVisualStyleBackColor = true;
            this.rdbtnBackToNormal.CheckedChanged += new System.EventHandler(this.rdbtnBackToNormal_CheckedChanged);
            // 
            // rdbtnWhite
            // 
            this.rdbtnWhite.AutoSize = true;
            this.rdbtnWhite.Location = new System.Drawing.Point(24, 73);
            this.rdbtnWhite.Name = "rdbtnWhite";
            this.rdbtnWhite.Size = new System.Drawing.Size(53, 17);
            this.rdbtnWhite.TabIndex = 3;
            this.rdbtnWhite.Text = "White";
            this.rdbtnWhite.UseVisualStyleBackColor = true;
            this.rdbtnWhite.CheckedChanged += new System.EventHandler(this.rdbtnWhite_CheckedChanged);
            // 
            // rdbtnRed
            // 
            this.rdbtnRed.AutoSize = true;
            this.rdbtnRed.Location = new System.Drawing.Point(24, 48);
            this.rdbtnRed.Name = "rdbtnRed";
            this.rdbtnRed.Size = new System.Drawing.Size(45, 17);
            this.rdbtnRed.TabIndex = 2;
            this.rdbtnRed.Text = "Red";
            this.rdbtnRed.UseVisualStyleBackColor = true;
            this.rdbtnRed.CheckedChanged += new System.EventHandler(this.rdbtnRed_CheckedChanged);
            // 
            // rdbtnYellow
            // 
            this.rdbtnYellow.AutoSize = true;
            this.rdbtnYellow.Location = new System.Drawing.Point(24, 23);
            this.rdbtnYellow.Name = "rdbtnYellow";
            this.rdbtnYellow.Size = new System.Drawing.Size(56, 17);
            this.rdbtnYellow.TabIndex = 1;
            this.rdbtnYellow.Text = "Yellow";
            this.rdbtnYellow.UseVisualStyleBackColor = true;
            this.rdbtnYellow.CheckedChanged += new System.EventHandler(this.rdbtnYellow_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(60, 183);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Color Changer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnBackToNormal;
        private System.Windows.Forms.RadioButton rdbtnWhite;
        private System.Windows.Forms.RadioButton rdbtnRed;
        private System.Windows.Forms.RadioButton rdbtnYellow;
        private System.Windows.Forms.Button btnExit;
    }
}

