namespace Change_Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picbx5Cent = new System.Windows.Forms.PictureBox();
            this.picbx10Cent = new System.Windows.Forms.PictureBox();
            this.picbx25Cent = new System.Windows.Forms.PictureBox();
            this.picbx50Cent = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbx5Cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx10Cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx25Cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx50Cent)).BeginInit();
            this.SuspendLayout();
            // 
            // picbx5Cent
            // 
            this.picbx5Cent.Image = ((System.Drawing.Image)(resources.GetObject("picbx5Cent.Image")));
            this.picbx5Cent.Location = new System.Drawing.Point(16, 27);
            this.picbx5Cent.Name = "picbx5Cent";
            this.picbx5Cent.Size = new System.Drawing.Size(125, 181);
            this.picbx5Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbx5Cent.TabIndex = 0;
            this.picbx5Cent.TabStop = false;
            this.picbx5Cent.Click += new System.EventHandler(this.picbx5Cent_Click);
            // 
            // picbx10Cent
            // 
            this.picbx10Cent.Image = ((System.Drawing.Image)(resources.GetObject("picbx10Cent.Image")));
            this.picbx10Cent.Location = new System.Drawing.Point(147, 27);
            this.picbx10Cent.Name = "picbx10Cent";
            this.picbx10Cent.Size = new System.Drawing.Size(125, 181);
            this.picbx10Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbx10Cent.TabIndex = 1;
            this.picbx10Cent.TabStop = false;
            this.picbx10Cent.Click += new System.EventHandler(this.picbx10Cent_Click);
            // 
            // picbx25Cent
            // 
            this.picbx25Cent.Image = ((System.Drawing.Image)(resources.GetObject("picbx25Cent.Image")));
            this.picbx25Cent.Location = new System.Drawing.Point(16, 214);
            this.picbx25Cent.Name = "picbx25Cent";
            this.picbx25Cent.Size = new System.Drawing.Size(125, 181);
            this.picbx25Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbx25Cent.TabIndex = 2;
            this.picbx25Cent.TabStop = false;
            this.picbx25Cent.Click += new System.EventHandler(this.picbx25Cent_Click);
            // 
            // picbx50Cent
            // 
            this.picbx50Cent.Image = ((System.Drawing.Image)(resources.GetObject("picbx50Cent.Image")));
            this.picbx50Cent.Location = new System.Drawing.Point(147, 214);
            this.picbx50Cent.Name = "picbx50Cent";
            this.picbx50Cent.Size = new System.Drawing.Size(125, 181);
            this.picbx50Cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbx50Cent.TabIndex = 3;
            this.picbx50Cent.TabStop = false;
            this.picbx50Cent.Click += new System.EventHandler(this.picbx50Cent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(156, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(278, 185);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Click the Coins";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picbx50Cent);
            this.Controls.Add(this.picbx25Cent);
            this.Controls.Add(this.picbx10Cent);
            this.Controls.Add(this.picbx5Cent);
            this.Name = "Form1";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.picbx5Cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx10Cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx25Cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx50Cent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbx5Cent;
        private System.Windows.Forms.PictureBox picbx10Cent;
        private System.Windows.Forms.PictureBox picbx25Cent;
        private System.Windows.Forms.PictureBox picbx50Cent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
    }
}

