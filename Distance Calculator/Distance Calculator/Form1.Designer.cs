namespace Distance_Calculator
{
    partial class frmDistanceCalculator
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
            this.txtbxMPH = new System.Windows.Forms.TextBox();
            this.txtbxHoursTraveled = new System.Windows.Forms.TextBox();
            this.lblMPH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstbxResults = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxMPH
            // 
            this.txtbxMPH.Location = new System.Drawing.Point(155, 13);
            this.txtbxMPH.Name = "txtbxMPH";
            this.txtbxMPH.Size = new System.Drawing.Size(100, 20);
            this.txtbxMPH.TabIndex = 0;
            // 
            // txtbxHoursTraveled
            // 
            this.txtbxHoursTraveled.Location = new System.Drawing.Point(155, 40);
            this.txtbxHoursTraveled.Name = "txtbxHoursTraveled";
            this.txtbxHoursTraveled.Size = new System.Drawing.Size(100, 20);
            this.txtbxHoursTraveled.TabIndex = 1;
            // 
            // lblMPH
            // 
            this.lblMPH.AutoSize = true;
            this.lblMPH.Location = new System.Drawing.Point(24, 19);
            this.lblMPH.Name = "lblMPH";
            this.lblMPH.Size = new System.Drawing.Size(117, 13);
            this.lblMPH.TabIndex = 2;
            this.lblMPH.Text = "Vehicle Speed in MPH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours Travled";
            // 
            // lstbxResults
            // 
            this.lstbxResults.FormattingEnabled = true;
            this.lstbxResults.Location = new System.Drawing.Point(28, 75);
            this.lstbxResults.Name = "lstbxResults";
            this.lstbxResults.Size = new System.Drawing.Size(227, 147);
            this.lstbxResults.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(70, 251);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(155, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDistanceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstbxResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMPH);
            this.Controls.Add(this.txtbxHoursTraveled);
            this.Controls.Add(this.txtbxMPH);
            this.Name = "frmDistanceCalculator";
            this.Text = "Distance Calcultor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxMPH;
        private System.Windows.Forms.TextBox txtbxHoursTraveled;
        private System.Windows.Forms.Label lblMPH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbxResults;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

