namespace Speed_Converter
{
    partial class frmSpeedConvertor
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
            this.lstbxOutput = new System.Windows.Forms.ListBox();
            this.btnDisplaySpeed = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxOutput
            // 
            this.lstbxOutput.FormattingEnabled = true;
            this.lstbxOutput.Location = new System.Drawing.Point(13, 13);
            this.lstbxOutput.Name = "lstbxOutput";
            this.lstbxOutput.Size = new System.Drawing.Size(259, 173);
            this.lstbxOutput.TabIndex = 0;
            // 
            // btnDisplaySpeed
            // 
            this.btnDisplaySpeed.Location = new System.Drawing.Point(33, 202);
            this.btnDisplaySpeed.Name = "btnDisplaySpeed";
            this.btnDisplaySpeed.Size = new System.Drawing.Size(75, 48);
            this.btnDisplaySpeed.TabIndex = 1;
            this.btnDisplaySpeed.Text = "Display Speed";
            this.btnDisplaySpeed.UseVisualStyleBackColor = true;
            this.btnDisplaySpeed.Click += new System.EventHandler(this.btnDisplaySpeed_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(114, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSpeedConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplaySpeed);
            this.Controls.Add(this.lstbxOutput);
            this.Name = "frmSpeedConvertor";
            this.Text = "Speed Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxOutput;
        private System.Windows.Forms.Button btnDisplaySpeed;
        private System.Windows.Forms.Button btnExit;
    }
}

