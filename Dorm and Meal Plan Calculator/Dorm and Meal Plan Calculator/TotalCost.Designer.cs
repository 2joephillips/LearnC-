namespace Dorm_and_Meal_Plan_Calculator
{
    partial class TotalCost
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
            this.lblTextCost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Total Cost is:";
            // 
            // lblTextCost
            // 
            this.lblTextCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTextCost.Location = new System.Drawing.Point(137, 12);
            this.lblTextCost.Name = "lblTextCost";
            this.lblTextCost.Size = new System.Drawing.Size(100, 23);
            this.lblTextCost.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(349, 78);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTextCost);
            this.Controls.Add(this.label1);
            this.Name = "TotalCost";
            this.Text = "Total Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTextCost;
        private System.Windows.Forms.Button button1;
    }
}