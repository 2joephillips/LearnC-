namespace CourseManager
{
    partial class CourseDiscrimnator
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
            this.components = new System.ComponentModel.Container();
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.onsiteGrideView = new System.Windows.Forms.DataGridView();
            this.onlineGridView = new System.Windows.Forms.DataGridView();
            this.onsiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.onsiteGrideView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onsiteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(13, 13);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(121, 21);
            this.departmentList.TabIndex = 0;
            // 
            // onsiteGrideView
            // 
            this.onsiteGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.onsiteGrideView.Location = new System.Drawing.Point(13, 40);
            this.onsiteGrideView.Name = "onsiteGrideView";
            this.onsiteGrideView.Size = new System.Drawing.Size(121, 150);
            this.onsiteGrideView.TabIndex = 1;
            // 
            // onlineGridView
            // 
            this.onlineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.onlineGridView.Location = new System.Drawing.Point(140, 40);
            this.onlineGridView.Name = "onlineGridView";
            this.onlineGridView.Size = new System.Drawing.Size(121, 150);
            this.onlineGridView.TabIndex = 2;
            // 
            // CourseDiscrimnator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.onlineGridView);
            this.Controls.Add(this.onsiteGrideView);
            this.Controls.Add(this.departmentList);
            this.Name = "CourseDiscrimnator";
            this.Text = "Course Discrimnator";
            ((System.ComponentModel.ISupportInitialize)(this.onsiteGrideView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onsiteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox departmentList;
        private System.Windows.Forms.DataGridView onsiteGrideView;
        private System.Windows.Forms.DataGridView onlineGridView;
        private System.Windows.Forms.BindingSource onsiteBindingSource;
    }
}