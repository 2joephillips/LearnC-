namespace Coin_Toss
{
    partial class frmCoinToss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoinToss));
            this.btnToss = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picboxHeads = new System.Windows.Forms.PictureBox();
            this.picbxTails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToss
            // 
            this.btnToss.Location = new System.Drawing.Point(20, 227);
            this.btnToss.Name = "btnToss";
            this.btnToss.Size = new System.Drawing.Size(75, 23);
            this.btnToss.TabIndex = 0;
            this.btnToss.Text = "Toss";
            this.btnToss.UseVisualStyleBackColor = true;
            this.btnToss.Click += new System.EventHandler(this.btnToss_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(101, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picboxHeads
            // 
            this.picboxHeads.Image = ((System.Drawing.Image)(resources.GetObject("picboxHeads.Image")));
            this.picboxHeads.Location = new System.Drawing.Point(20, 12);
            this.picboxHeads.Name = "picboxHeads";
            this.picboxHeads.Size = new System.Drawing.Size(170, 170);
            this.picboxHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxHeads.TabIndex = 2;
            this.picboxHeads.TabStop = false;
            // 
            // picbxTails
            // 
            this.picbxTails.Image = ((System.Drawing.Image)(resources.GetObject("picbxTails.Image")));
            this.picbxTails.Location = new System.Drawing.Point(22, 12);
            this.picbxTails.Name = "picbxTails";
            this.picbxTails.Size = new System.Drawing.Size(170, 170);
            this.picbxTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbxTails.TabIndex = 3;
            this.picbxTails.TabStop = false;
            this.picbxTails.Visible = false;
            // 
            // frmCoinToss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 262);
            this.Controls.Add(this.picbxTails);
            this.Controls.Add(this.picboxHeads);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnToss);
            this.Name = "frmCoinToss";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.picboxHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToss;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picboxHeads;
        private System.Windows.Forms.PictureBox picbxTails;
    }
}

