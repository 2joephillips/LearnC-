namespace CourseManager
{
    partial class CourseViewer
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
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewDiscrimnator = new System.Windows.Forms.Button();
            this.viewOffices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(13, 13);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(121, 21);
            this.departmentList.TabIndex = 0;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(13, 227);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(75, 44);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(13, 71);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.Size = new System.Drawing.Size(319, 151);
            this.courseGridView.TabIndex = 2;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(95, 228);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(75, 44);
            this.saveChanges.TabIndex = 3;
            this.saveChanges.Text = "Update";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Enrollment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewDiscrimnator
            // 
            this.viewDiscrimnator.Location = new System.Drawing.Point(257, 228);
            this.viewDiscrimnator.Name = "viewDiscrimnator";
            this.viewDiscrimnator.Size = new System.Drawing.Size(75, 44);
            this.viewDiscrimnator.TabIndex = 5;
            this.viewDiscrimnator.Text = "Online  vs. Onsight";
            this.viewDiscrimnator.UseVisualStyleBackColor = true;
            this.viewDiscrimnator.Click += new System.EventHandler(this.viewDiscrimnator_Click);
            // 
            // viewOffices
            // 
            this.viewOffices.Location = new System.Drawing.Point(344, 227);
            this.viewOffices.Name = "viewOffices";
            this.viewOffices.Size = new System.Drawing.Size(75, 44);
            this.viewOffices.TabIndex = 6;
            this.viewOffices.Text = "View Offices";
            this.viewOffices.UseVisualStyleBackColor = true;
            this.viewOffices.Click += new System.EventHandler(this.viewOffices_Click);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 326);
            this.Controls.Add(this.viewOffices);
            this.Controls.Add(this.viewDiscrimnator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.departmentList);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewDiscrimnator;
        private System.Windows.Forms.Button viewOffices;
    }
}

