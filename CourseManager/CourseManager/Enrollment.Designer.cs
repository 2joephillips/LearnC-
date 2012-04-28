namespace CourseManager
{
    partial class Enrollment
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
            this.courseList = new System.Windows.Forms.ComboBox();
            this.studentList = new System.Windows.Forms.ListBox();
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
            // courseList
            // 
            this.courseList.FormattingEnabled = true;
            this.courseList.Location = new System.Drawing.Point(140, 13);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(121, 21);
            this.courseList.TabIndex = 1;
            this.courseList.SelectedIndexChanged += new System.EventHandler(this.courseList_SelectedIndexChanged);
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(13, 41);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(248, 212);
            this.studentList.TabIndex = 2;
            // 
            // Enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.studentList);
            this.Controls.Add(this.courseList);
            this.Controls.Add(this.departmentList);
            this.Name = "Enrollment";
            this.Text = "Enrollment";
            this.Load += new System.EventHandler(this.Enrollment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.ComboBox courseList;
        private System.Windows.Forms.ListBox studentList;
    }
}