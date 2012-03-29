namespace DrinkVendingMachineSimulator
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
            this.pnlCola = new System.Windows.Forms.Panel();
            this.pctrbxCola = new System.Windows.Forms.PictureBox();
            this.lblPriceCola = new System.Windows.Forms.Label();
            this.lblDrinksLeftDescCola = new System.Windows.Forms.Label();
            this.lblDrinksLeftCola = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDrinksLeftRootBeer = new System.Windows.Forms.Label();
            this.lblDrinksLeftDescRootBeer = new System.Windows.Forms.Label();
            this.lblPriceRootBeer = new System.Windows.Forms.Label();
            this.pctrbxRootBeer = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDrinksLeftLemonLime = new System.Windows.Forms.Label();
            this.lblDrinksLeftDescLemonLime = new System.Windows.Forms.Label();
            this.lblPriceLemonLime = new System.Windows.Forms.Label();
            this.pctrbxLemonLime = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDrinksLeftGrapeSoda = new System.Windows.Forms.Label();
            this.lblDrinksLeftDescGrapeSoda = new System.Windows.Forms.Label();
            this.lblPriceGrapeSoda = new System.Windows.Forms.Label();
            this.pctrbxGrapeSoda = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDrinksLeftCreamSoda = new System.Windows.Forms.Label();
            this.lblDrinksLeftDescCreamSoda = new System.Windows.Forms.Label();
            this.lblPriceCreamSoda = new System.Windows.Forms.Label();
            this.pctrbxCreamSoda = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalSalesDesc = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlCola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCola)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxRootBeer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLemonLime)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGrapeSoda)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCreamSoda)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCola
            // 
            this.pnlCola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCola.Controls.Add(this.lblDrinksLeftCola);
            this.pnlCola.Controls.Add(this.lblDrinksLeftDescCola);
            this.pnlCola.Controls.Add(this.lblPriceCola);
            this.pnlCola.Controls.Add(this.pctrbxCola);
            this.pnlCola.Location = new System.Drawing.Point(22, 23);
            this.pnlCola.Name = "pnlCola";
            this.pnlCola.Size = new System.Drawing.Size(204, 72);
            this.pnlCola.TabIndex = 0;
            // 
            // pctrbxCola
            // 
            this.pctrbxCola.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxCola.Image")));
            this.pctrbxCola.Location = new System.Drawing.Point(3, 3);
            this.pctrbxCola.Name = "pctrbxCola";
            this.pctrbxCola.Size = new System.Drawing.Size(64, 64);
            this.pctrbxCola.TabIndex = 0;
            this.pctrbxCola.TabStop = false;
            this.pctrbxCola.Click += new System.EventHandler(this.pctrbxCola_Click);
            // 
            // lblPriceCola
            // 
            this.lblPriceCola.AutoSize = true;
            this.lblPriceCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCola.Location = new System.Drawing.Point(120, 3);
            this.lblPriceCola.Name = "lblPriceCola";
            this.lblPriceCola.Size = new System.Drawing.Size(44, 16);
            this.lblPriceCola.TabIndex = 1;
            this.lblPriceCola.Text = "$1.00";
            // 
            // lblDrinksLeftDescCola
            // 
            this.lblDrinksLeftDescCola.AutoSize = true;
            this.lblDrinksLeftDescCola.Location = new System.Drawing.Point(112, 19);
            this.lblDrinksLeftDescCola.Name = "lblDrinksLeftDescCola";
            this.lblDrinksLeftDescCola.Size = new System.Drawing.Size(61, 13);
            this.lblDrinksLeftDescCola.TabIndex = 2;
            this.lblDrinksLeftDescCola.Text = "Drinks Left:";
            // 
            // lblDrinksLeftCola
            // 
            this.lblDrinksLeftCola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrinksLeftCola.Location = new System.Drawing.Point(92, 44);
            this.lblDrinksLeftCola.Name = "lblDrinksLeftCola";
            this.lblDrinksLeftCola.Size = new System.Drawing.Size(100, 23);
            this.lblDrinksLeftCola.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDrinksLeftRootBeer);
            this.panel1.Controls.Add(this.lblDrinksLeftDescRootBeer);
            this.panel1.Controls.Add(this.lblPriceRootBeer);
            this.panel1.Controls.Add(this.pctrbxRootBeer);
            this.panel1.Location = new System.Drawing.Point(232, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 72);
            this.panel1.TabIndex = 1;
            // 
            // lblDrinksLeftRootBeer
            // 
            this.lblDrinksLeftRootBeer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrinksLeftRootBeer.Location = new System.Drawing.Point(92, 44);
            this.lblDrinksLeftRootBeer.Name = "lblDrinksLeftRootBeer";
            this.lblDrinksLeftRootBeer.Size = new System.Drawing.Size(100, 23);
            this.lblDrinksLeftRootBeer.TabIndex = 3;
            // 
            // lblDrinksLeftDescRootBeer
            // 
            this.lblDrinksLeftDescRootBeer.AutoSize = true;
            this.lblDrinksLeftDescRootBeer.Location = new System.Drawing.Point(112, 19);
            this.lblDrinksLeftDescRootBeer.Name = "lblDrinksLeftDescRootBeer";
            this.lblDrinksLeftDescRootBeer.Size = new System.Drawing.Size(61, 13);
            this.lblDrinksLeftDescRootBeer.TabIndex = 2;
            this.lblDrinksLeftDescRootBeer.Text = "Drinks Left:";
            // 
            // lblPriceRootBeer
            // 
            this.lblPriceRootBeer.AutoSize = true;
            this.lblPriceRootBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceRootBeer.Location = new System.Drawing.Point(120, 3);
            this.lblPriceRootBeer.Name = "lblPriceRootBeer";
            this.lblPriceRootBeer.Size = new System.Drawing.Size(44, 16);
            this.lblPriceRootBeer.TabIndex = 1;
            this.lblPriceRootBeer.Text = "$1.00";
            // 
            // pctrbxRootBeer
            // 
            this.pctrbxRootBeer.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxRootBeer.Image")));
            this.pctrbxRootBeer.Location = new System.Drawing.Point(3, 3);
            this.pctrbxRootBeer.Name = "pctrbxRootBeer";
            this.pctrbxRootBeer.Size = new System.Drawing.Size(64, 64);
            this.pctrbxRootBeer.TabIndex = 0;
            this.pctrbxRootBeer.TabStop = false;
            this.pctrbxRootBeer.Click += new System.EventHandler(this.pctrbxRootBeer_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblDrinksLeftLemonLime);
            this.panel2.Controls.Add(this.lblDrinksLeftDescLemonLime);
            this.panel2.Controls.Add(this.lblPriceLemonLime);
            this.panel2.Controls.Add(this.pctrbxLemonLime);
            this.panel2.Location = new System.Drawing.Point(22, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 72);
            this.panel2.TabIndex = 4;
            // 
            // lblDrinksLeftLemonLime
            // 
            this.lblDrinksLeftLemonLime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrinksLeftLemonLime.Location = new System.Drawing.Point(92, 44);
            this.lblDrinksLeftLemonLime.Name = "lblDrinksLeftLemonLime";
            this.lblDrinksLeftLemonLime.Size = new System.Drawing.Size(100, 23);
            this.lblDrinksLeftLemonLime.TabIndex = 3;
            // 
            // lblDrinksLeftDescLemonLime
            // 
            this.lblDrinksLeftDescLemonLime.AutoSize = true;
            this.lblDrinksLeftDescLemonLime.Location = new System.Drawing.Point(112, 19);
            this.lblDrinksLeftDescLemonLime.Name = "lblDrinksLeftDescLemonLime";
            this.lblDrinksLeftDescLemonLime.Size = new System.Drawing.Size(61, 13);
            this.lblDrinksLeftDescLemonLime.TabIndex = 2;
            this.lblDrinksLeftDescLemonLime.Text = "Drinks Left:";
            // 
            // lblPriceLemonLime
            // 
            this.lblPriceLemonLime.AutoSize = true;
            this.lblPriceLemonLime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceLemonLime.Location = new System.Drawing.Point(120, 3);
            this.lblPriceLemonLime.Name = "lblPriceLemonLime";
            this.lblPriceLemonLime.Size = new System.Drawing.Size(44, 16);
            this.lblPriceLemonLime.TabIndex = 1;
            this.lblPriceLemonLime.Text = "$1.00";
            // 
            // pctrbxLemonLime
            // 
            this.pctrbxLemonLime.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxLemonLime.Image")));
            this.pctrbxLemonLime.Location = new System.Drawing.Point(3, 3);
            this.pctrbxLemonLime.Name = "pctrbxLemonLime";
            this.pctrbxLemonLime.Size = new System.Drawing.Size(64, 64);
            this.pctrbxLemonLime.TabIndex = 0;
            this.pctrbxLemonLime.TabStop = false;
            this.pctrbxLemonLime.Click += new System.EventHandler(this.pctrbxLemonLime_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblDrinksLeftGrapeSoda);
            this.panel3.Controls.Add(this.lblDrinksLeftDescGrapeSoda);
            this.panel3.Controls.Add(this.lblPriceGrapeSoda);
            this.panel3.Controls.Add(this.pctrbxGrapeSoda);
            this.panel3.Location = new System.Drawing.Point(232, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 72);
            this.panel3.TabIndex = 4;
            // 
            // lblDrinksLeftGrapeSoda
            // 
            this.lblDrinksLeftGrapeSoda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrinksLeftGrapeSoda.Location = new System.Drawing.Point(92, 44);
            this.lblDrinksLeftGrapeSoda.Name = "lblDrinksLeftGrapeSoda";
            this.lblDrinksLeftGrapeSoda.Size = new System.Drawing.Size(100, 23);
            this.lblDrinksLeftGrapeSoda.TabIndex = 3;
            // 
            // lblDrinksLeftDescGrapeSoda
            // 
            this.lblDrinksLeftDescGrapeSoda.AutoSize = true;
            this.lblDrinksLeftDescGrapeSoda.Location = new System.Drawing.Point(112, 19);
            this.lblDrinksLeftDescGrapeSoda.Name = "lblDrinksLeftDescGrapeSoda";
            this.lblDrinksLeftDescGrapeSoda.Size = new System.Drawing.Size(61, 13);
            this.lblDrinksLeftDescGrapeSoda.TabIndex = 2;
            this.lblDrinksLeftDescGrapeSoda.Text = "Drinks Left:";
            // 
            // lblPriceGrapeSoda
            // 
            this.lblPriceGrapeSoda.AutoSize = true;
            this.lblPriceGrapeSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceGrapeSoda.Location = new System.Drawing.Point(120, 3);
            this.lblPriceGrapeSoda.Name = "lblPriceGrapeSoda";
            this.lblPriceGrapeSoda.Size = new System.Drawing.Size(44, 16);
            this.lblPriceGrapeSoda.TabIndex = 1;
            this.lblPriceGrapeSoda.Text = "$1.50";
            // 
            // pctrbxGrapeSoda
            // 
            this.pctrbxGrapeSoda.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxGrapeSoda.Image")));
            this.pctrbxGrapeSoda.Location = new System.Drawing.Point(3, 3);
            this.pctrbxGrapeSoda.Name = "pctrbxGrapeSoda";
            this.pctrbxGrapeSoda.Size = new System.Drawing.Size(64, 64);
            this.pctrbxGrapeSoda.TabIndex = 0;
            this.pctrbxGrapeSoda.TabStop = false;
            this.pctrbxGrapeSoda.Click += new System.EventHandler(this.pctrbxGrapeSoda_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblDrinksLeftCreamSoda);
            this.panel4.Controls.Add(this.lblDrinksLeftDescCreamSoda);
            this.panel4.Controls.Add(this.lblPriceCreamSoda);
            this.panel4.Controls.Add(this.pctrbxCreamSoda);
            this.panel4.Location = new System.Drawing.Point(22, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 72);
            this.panel4.TabIndex = 4;
            // 
            // lblDrinksLeftCreamSoda
            // 
            this.lblDrinksLeftCreamSoda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDrinksLeftCreamSoda.Location = new System.Drawing.Point(92, 44);
            this.lblDrinksLeftCreamSoda.Name = "lblDrinksLeftCreamSoda";
            this.lblDrinksLeftCreamSoda.Size = new System.Drawing.Size(100, 23);
            this.lblDrinksLeftCreamSoda.TabIndex = 3;
            // 
            // lblDrinksLeftDescCreamSoda
            // 
            this.lblDrinksLeftDescCreamSoda.AutoSize = true;
            this.lblDrinksLeftDescCreamSoda.Location = new System.Drawing.Point(112, 19);
            this.lblDrinksLeftDescCreamSoda.Name = "lblDrinksLeftDescCreamSoda";
            this.lblDrinksLeftDescCreamSoda.Size = new System.Drawing.Size(61, 13);
            this.lblDrinksLeftDescCreamSoda.TabIndex = 2;
            this.lblDrinksLeftDescCreamSoda.Text = "Drinks Left:";
            // 
            // lblPriceCreamSoda
            // 
            this.lblPriceCreamSoda.AutoSize = true;
            this.lblPriceCreamSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCreamSoda.Location = new System.Drawing.Point(120, 3);
            this.lblPriceCreamSoda.Name = "lblPriceCreamSoda";
            this.lblPriceCreamSoda.Size = new System.Drawing.Size(44, 16);
            this.lblPriceCreamSoda.TabIndex = 1;
            this.lblPriceCreamSoda.Text = "$1.50";
            // 
            // pctrbxCreamSoda
            // 
            this.pctrbxCreamSoda.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxCreamSoda.Image")));
            this.pctrbxCreamSoda.Location = new System.Drawing.Point(3, 3);
            this.pctrbxCreamSoda.Name = "pctrbxCreamSoda";
            this.pctrbxCreamSoda.Size = new System.Drawing.Size(64, 64);
            this.pctrbxCreamSoda.TabIndex = 0;
            this.pctrbxCreamSoda.TabStop = false;
            this.pctrbxCreamSoda.Click += new System.EventHandler(this.pctrbxCreamSoda_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblTotalSales);
            this.panel5.Controls.Add(this.lblTotalSalesDesc);
            this.panel5.Location = new System.Drawing.Point(232, 179);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 72);
            this.panel5.TabIndex = 5;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSales.Location = new System.Drawing.Point(59, 41);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(100, 23);
            this.lblTotalSales.TabIndex = 3;
            // 
            // lblTotalSalesDesc
            // 
            this.lblTotalSalesDesc.AutoSize = true;
            this.lblTotalSalesDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesDesc.Location = new System.Drawing.Point(65, 16);
            this.lblTotalSalesDesc.Name = "lblTotalSalesDesc";
            this.lblTotalSalesDesc.Size = new System.Drawing.Size(88, 16);
            this.lblTotalSalesDesc.TabIndex = 1;
            this.lblTotalSalesDesc.Text = "Total Sales";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(192, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 311);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCola);
            this.Name = "Form1";
            this.Text = "Drink Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCola.ResumeLayout(false);
            this.pnlCola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCola)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxRootBeer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxLemonLime)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxGrapeSoda)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxCreamSoda)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCola;
        private System.Windows.Forms.Label lblDrinksLeftCola;
        private System.Windows.Forms.Label lblDrinksLeftDescCola;
        private System.Windows.Forms.Label lblPriceCola;
        private System.Windows.Forms.PictureBox pctrbxCola;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDrinksLeftRootBeer;
        private System.Windows.Forms.Label lblDrinksLeftDescRootBeer;
        private System.Windows.Forms.Label lblPriceRootBeer;
        private System.Windows.Forms.PictureBox pctrbxRootBeer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDrinksLeftLemonLime;
        private System.Windows.Forms.Label lblDrinksLeftDescLemonLime;
        private System.Windows.Forms.Label lblPriceLemonLime;
        private System.Windows.Forms.PictureBox pctrbxLemonLime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDrinksLeftGrapeSoda;
        private System.Windows.Forms.Label lblDrinksLeftDescGrapeSoda;
        private System.Windows.Forms.Label lblPriceGrapeSoda;
        private System.Windows.Forms.PictureBox pctrbxGrapeSoda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDrinksLeftCreamSoda;
        private System.Windows.Forms.Label lblDrinksLeftDescCreamSoda;
        private System.Windows.Forms.Label lblPriceCreamSoda;
        private System.Windows.Forms.PictureBox pctrbxCreamSoda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalSalesDesc;
        private System.Windows.Forms.Button btnExit;
    }
}

