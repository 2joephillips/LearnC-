namespace Serialization
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
            this.button1 = new System.Windows.Forms.Button();
            this.OLVCars = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OLVCars)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OLVCars
            // 
            this.OLVCars.AllColumns.Add(this.olvColumn1);
            this.OLVCars.AllColumns.Add(this.olvColumn2);
            this.OLVCars.AllColumns.Add(this.olvColumn3);
            this.OLVCars.AllColumns.Add(this.olvColumn4);
            this.OLVCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.OLVCars.Location = new System.Drawing.Point(12, 157);
            this.OLVCars.Name = "OLVCars";
            this.OLVCars.Size = new System.Drawing.Size(583, 219);
            this.OLVCars.TabIndex = 1;
            this.OLVCars.UseCompatibleStateImageBehavior = false;
            this.OLVCars.View = System.Windows.Forms.View.Details;
            this.OLVCars.AfterCreatingGroups += new System.EventHandler<BrightIdeasSoftware.CreateGroupsEventArgs>(this.OLVCars_AfterCreatingGroups);
            this.OLVCars.BeforeCreatingGroups += new System.EventHandler<BrightIdeasSoftware.CreateGroupsEventArgs>(this.OLVCars_BeforeCreatingGroups);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Make";
            this.olvColumn1.Text = "Make";
            this.olvColumn1.Width = 53;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Model";
            this.olvColumn2.Groupable = false;
            this.olvColumn2.Text = "Model";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Year";
            this.olvColumn3.Groupable = false;
            this.olvColumn3.Text = "Year";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Owner.FirstName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 417);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OLVCars);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Serialization Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OLVCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BrightIdeasSoftware.ObjectListView OLVCars;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

