namespace Orion_Constellation
{
    partial class orionConstellationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orionConstellationForm));
            this.showStarNamesButton = new System.Windows.Forms.Button();
            this.hideStarNamesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.betelgeuseLabel = new System.Windows.Forms.Label();
            this.meissaLabel = new System.Windows.Forms.Label();
            this.alnitakLabel = new System.Windows.Forms.Label();
            this.alnilamLabel = new System.Windows.Forms.Label();
            this.mintakaLabel = new System.Windows.Forms.Label();
            this.saiphLabel = new System.Windows.Forms.Label();
            this.rigelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // showStarNamesButton
            // 
            this.showStarNamesButton.Location = new System.Drawing.Point(82, 489);
            this.showStarNamesButton.Name = "showStarNamesButton";
            this.showStarNamesButton.Size = new System.Drawing.Size(75, 39);
            this.showStarNamesButton.TabIndex = 0;
            this.showStarNamesButton.Text = "Show Star Names";
            this.showStarNamesButton.UseVisualStyleBackColor = true;
            this.showStarNamesButton.Click += new System.EventHandler(this.showStarNamesButton_Click);
            // 
            // hideStarNamesButton
            // 
            this.hideStarNamesButton.Location = new System.Drawing.Point(174, 489);
            this.hideStarNamesButton.Name = "hideStarNamesButton";
            this.hideStarNamesButton.Size = new System.Drawing.Size(75, 39);
            this.hideStarNamesButton.TabIndex = 1;
            this.hideStarNamesButton.Text = "Hide Star Names";
            this.hideStarNamesButton.UseVisualStyleBackColor = true;
            this.hideStarNamesButton.Click += new System.EventHandler(this.hideStarNamesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(266, 489);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 39);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // betelgeuseLabel
            // 
            this.betelgeuseLabel.AutoSize = true;
            this.betelgeuseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betelgeuseLabel.Location = new System.Drawing.Point(99, 43);
            this.betelgeuseLabel.Name = "betelgeuseLabel";
            this.betelgeuseLabel.Size = new System.Drawing.Size(77, 16);
            this.betelgeuseLabel.TabIndex = 4;
            this.betelgeuseLabel.Text = "Betelgeuse";
            // 
            // meissaLabel
            // 
            this.meissaLabel.AutoSize = true;
            this.meissaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meissaLabel.Location = new System.Drawing.Point(296, 79);
            this.meissaLabel.Name = "meissaLabel";
            this.meissaLabel.Size = new System.Drawing.Size(52, 16);
            this.meissaLabel.TabIndex = 5;
            this.meissaLabel.Text = "Meissa";
            // 
            // alnitakLabel
            // 
            this.alnitakLabel.AutoSize = true;
            this.alnitakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alnitakLabel.Location = new System.Drawing.Point(79, 238);
            this.alnitakLabel.Name = "alnitakLabel";
            this.alnitakLabel.Size = new System.Drawing.Size(48, 16);
            this.alnitakLabel.TabIndex = 6;
            this.alnitakLabel.Text = "Alnitak";
            // 
            // alnilamLabel
            // 
            this.alnilamLabel.AutoSize = true;
            this.alnilamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alnilamLabel.Location = new System.Drawing.Point(147, 203);
            this.alnilamLabel.Name = "alnilamLabel";
            this.alnilamLabel.Size = new System.Drawing.Size(52, 16);
            this.alnilamLabel.TabIndex = 7;
            this.alnilamLabel.Text = "Alnilam";
            // 
            // mintakaLabel
            // 
            this.mintakaLabel.AutoSize = true;
            this.mintakaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintakaLabel.Location = new System.Drawing.Point(250, 201);
            this.mintakaLabel.Name = "mintakaLabel";
            this.mintakaLabel.Size = new System.Drawing.Size(55, 16);
            this.mintakaLabel.TabIndex = 8;
            this.mintakaLabel.Text = "Mintaka";
            // 
            // saiphLabel
            // 
            this.saiphLabel.AutoSize = true;
            this.saiphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saiphLabel.Location = new System.Drawing.Point(82, 400);
            this.saiphLabel.Name = "saiphLabel";
            this.saiphLabel.Size = new System.Drawing.Size(43, 16);
            this.saiphLabel.TabIndex = 9;
            this.saiphLabel.Text = "Saiph";
            // 
            // rigelLabel
            // 
            this.rigelLabel.AutoSize = true;
            this.rigelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rigelLabel.Location = new System.Drawing.Point(269, 372);
            this.rigelLabel.Name = "rigelLabel";
            this.rigelLabel.Size = new System.Drawing.Size(40, 16);
            this.rigelLabel.TabIndex = 10;
            this.rigelLabel.Text = "Rigel";
            // 
            // orionConstellationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 540);
            this.Controls.Add(this.rigelLabel);
            this.Controls.Add(this.saiphLabel);
            this.Controls.Add(this.mintakaLabel);
            this.Controls.Add(this.alnilamLabel);
            this.Controls.Add(this.alnitakLabel);
            this.Controls.Add(this.meissaLabel);
            this.Controls.Add(this.betelgeuseLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.hideStarNamesButton);
            this.Controls.Add(this.showStarNamesButton);
            this.Name = "orionConstellationForm";
            this.Text = "Orion Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showStarNamesButton;
        private System.Windows.Forms.Button hideStarNamesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label betelgeuseLabel;
        private System.Windows.Forms.Label meissaLabel;
        private System.Windows.Forms.Label alnitakLabel;
        private System.Windows.Forms.Label alnilamLabel;
        private System.Windows.Forms.Label mintakaLabel;
        private System.Windows.Forms.Label saiphLabel;
        private System.Windows.Forms.Label rigelLabel;
    }
}

