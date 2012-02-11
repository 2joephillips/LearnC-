namespace Birthdate_String
{
    partial class BirthDateForm
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
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDateOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxDayofMonth = new System.Windows.Forms.TextBox();
            this.txtbxDayofWeek = new System.Windows.Forms.TextBox();
            this.txtbxYear = new System.Windows.Forms.TextBox();
            this.txtbxMonth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnShowDate
            // 
            this.btnShowDate.Location = new System.Drawing.Point(12, 202);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(75, 23);
            this.btnShowDate.TabIndex = 4;
            this.btnShowDate.Text = "Show Date";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(111, 202);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDateOutput
            // 
            this.lblDateOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateOutput.Location = new System.Drawing.Point(12, 142);
            this.lblDateOutput.Name = "lblDateOutput";
            this.lblDateOutput.Size = new System.Drawing.Size(273, 40);
            this.lblDateOutput.TabIndex = 3;
            this.lblDateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the day of the week";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the year";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter the name of the month";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter the numeric day of the month";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtbxDayofMonth
            // 
            this.txtbxDayofMonth.Location = new System.Drawing.Point(190, 80);
            this.txtbxDayofMonth.Name = "txtbxDayofMonth";
            this.txtbxDayofMonth.Size = new System.Drawing.Size(100, 20);
            this.txtbxDayofMonth.TabIndex = 2;
            // 
            // txtbxDayofWeek
            // 
            this.txtbxDayofWeek.Location = new System.Drawing.Point(188, 22);
            this.txtbxDayofWeek.Name = "txtbxDayofWeek";
            this.txtbxDayofWeek.Size = new System.Drawing.Size(100, 20);
            this.txtbxDayofWeek.TabIndex = 0;
            // 
            // txtbxYear
            // 
            this.txtbxYear.Location = new System.Drawing.Point(190, 109);
            this.txtbxYear.Name = "txtbxYear";
            this.txtbxYear.Size = new System.Drawing.Size(100, 20);
            this.txtbxYear.TabIndex = 3;
            // 
            // txtbxMonth
            // 
            this.txtbxMonth.Location = new System.Drawing.Point(188, 51);
            this.txtbxMonth.Name = "txtbxMonth";
            this.txtbxMonth.Size = new System.Drawing.Size(100, 20);
            this.txtbxMonth.TabIndex = 1;
            // 
            // BirthDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 242);
            this.Controls.Add(this.txtbxMonth);
            this.Controls.Add(this.txtbxYear);
            this.Controls.Add(this.txtbxDayofWeek);
            this.Controls.Add(this.txtbxDayofMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDateOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowDate);
            this.Name = "BirthDateForm";
            this.Text = "Birth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDateOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxDayofMonth;
        private System.Windows.Forms.TextBox txtbxDayofWeek;
        private System.Windows.Forms.TextBox txtbxYear;
        private System.Windows.Forms.TextBox txtbxMonth;
    }
}

