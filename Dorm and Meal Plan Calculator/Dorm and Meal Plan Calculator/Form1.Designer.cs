namespace Dorm_and_Meal_Plan_Calculator
{
    partial class formDormNMealPlan
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
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpBoxDorm = new System.Windows.Forms.GroupBox();
            this.rdDrmUniversity = new System.Windows.Forms.RadioButton();
            this.rdDrmFarthing = new System.Windows.Forms.RadioButton();
            this.rdDrmPike = new System.Windows.Forms.RadioButton();
            this.rdDrmAllen = new System.Windows.Forms.RadioButton();
            this.grpboxMealPlan = new System.Windows.Forms.GroupBox();
            this.rdMealUnlimited = new System.Windows.Forms.RadioButton();
            this.rdMeal14 = new System.Windows.Forms.RadioButton();
            this.rdMealPlan7 = new System.Windows.Forms.RadioButton();
            this.grpBoxDorm.SuspendLayout();
            this.grpboxMealPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(2, 144);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(75, 46);
            this.btnCalculateCost.TabIndex = 4;
            this.btnCalculateCost.Text = "Calculate the Cost";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(83, 144);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpBoxDorm
            // 
            this.grpBoxDorm.Controls.Add(this.rdDrmUniversity);
            this.grpBoxDorm.Controls.Add(this.rdDrmFarthing);
            this.grpBoxDorm.Controls.Add(this.rdDrmPike);
            this.grpBoxDorm.Controls.Add(this.rdDrmAllen);
            this.grpBoxDorm.Location = new System.Drawing.Point(2, 12);
            this.grpBoxDorm.Name = "grpBoxDorm";
            this.grpBoxDorm.Size = new System.Drawing.Size(156, 126);
            this.grpBoxDorm.TabIndex = 6;
            this.grpBoxDorm.TabStop = false;
            this.grpBoxDorm.Text = "Select Dorm";
            // 
            // rdDrmUniversity
            // 
            this.rdDrmUniversity.AutoSize = true;
            this.rdDrmUniversity.Location = new System.Drawing.Point(10, 94);
            this.rdDrmUniversity.Name = "rdDrmUniversity";
            this.rdDrmUniversity.Size = new System.Drawing.Size(103, 17);
            this.rdDrmUniversity.TabIndex = 3;
            this.rdDrmUniversity.TabStop = true;
            this.rdDrmUniversity.Text = "University Suites";
            this.rdDrmUniversity.UseVisualStyleBackColor = true;
            // 
            // rdDrmFarthing
            // 
            this.rdDrmFarthing.AutoSize = true;
            this.rdDrmFarthing.Location = new System.Drawing.Point(10, 69);
            this.rdDrmFarthing.Name = "rdDrmFarthing";
            this.rdDrmFarthing.Size = new System.Drawing.Size(84, 17);
            this.rdDrmFarthing.TabIndex = 2;
            this.rdDrmFarthing.TabStop = true;
            this.rdDrmFarthing.Text = "Farthing Hall";
            this.rdDrmFarthing.UseVisualStyleBackColor = true;
            // 
            // rdDrmPike
            // 
            this.rdDrmPike.AutoSize = true;
            this.rdDrmPike.Location = new System.Drawing.Point(10, 44);
            this.rdDrmPike.Name = "rdDrmPike";
            this.rdDrmPike.Size = new System.Drawing.Size(67, 17);
            this.rdDrmPike.TabIndex = 1;
            this.rdDrmPike.TabStop = true;
            this.rdDrmPike.Text = "Pike Hall";
            this.rdDrmPike.UseVisualStyleBackColor = true;
            // 
            // rdDrmAllen
            // 
            this.rdDrmAllen.AutoSize = true;
            this.rdDrmAllen.Checked = true;
            this.rdDrmAllen.Location = new System.Drawing.Point(10, 19);
            this.rdDrmAllen.Name = "rdDrmAllen";
            this.rdDrmAllen.Size = new System.Drawing.Size(69, 17);
            this.rdDrmAllen.TabIndex = 0;
            this.rdDrmAllen.TabStop = true;
            this.rdDrmAllen.Text = "Allen Hall";
            this.rdDrmAllen.UseVisualStyleBackColor = true;
            // 
            // grpboxMealPlan
            // 
            this.grpboxMealPlan.Controls.Add(this.rdMealUnlimited);
            this.grpboxMealPlan.Controls.Add(this.rdMeal14);
            this.grpboxMealPlan.Controls.Add(this.rdMealPlan7);
            this.grpboxMealPlan.Location = new System.Drawing.Point(164, 19);
            this.grpboxMealPlan.Name = "grpboxMealPlan";
            this.grpboxMealPlan.Size = new System.Drawing.Size(156, 119);
            this.grpboxMealPlan.TabIndex = 7;
            this.grpboxMealPlan.TabStop = false;
            this.grpboxMealPlan.Text = "Select Meal Plan";
            // 
            // rdMealUnlimited
            // 
            this.rdMealUnlimited.AutoSize = true;
            this.rdMealUnlimited.Location = new System.Drawing.Point(10, 65);
            this.rdMealUnlimited.Name = "rdMealUnlimited";
            this.rdMealUnlimited.Size = new System.Drawing.Size(97, 17);
            this.rdMealUnlimited.TabIndex = 3;
            this.rdMealUnlimited.TabStop = true;
            this.rdMealUnlimited.Text = "Unlimted Meals\r\n";
            this.rdMealUnlimited.UseVisualStyleBackColor = true;
            // 
            // rdMeal14
            // 
            this.rdMeal14.AutoSize = true;
            this.rdMeal14.Location = new System.Drawing.Point(10, 42);
            this.rdMeal14.Name = "rdMeal14";
            this.rdMeal14.Size = new System.Drawing.Size(68, 17);
            this.rdMeal14.TabIndex = 2;
            this.rdMeal14.TabStop = true;
            this.rdMeal14.Text = "14 Meals";
            this.rdMeal14.UseVisualStyleBackColor = true;
            // 
            // rdMealPlan7
            // 
            this.rdMealPlan7.AutoSize = true;
            this.rdMealPlan7.Checked = true;
            this.rdMealPlan7.Location = new System.Drawing.Point(10, 19);
            this.rdMealPlan7.Name = "rdMealPlan7";
            this.rdMealPlan7.Size = new System.Drawing.Size(62, 17);
            this.rdMealPlan7.TabIndex = 1;
            this.rdMealPlan7.TabStop = true;
            this.rdMealPlan7.Text = "7 Meals";
            this.rdMealPlan7.UseVisualStyleBackColor = true;
            // 
            // formDormNMealPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 202);
            this.Controls.Add(this.grpboxMealPlan);
            this.Controls.Add(this.grpBoxDorm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculateCost);
            this.Name = "formDormNMealPlan";
            this.Text = "Calculate Dorm and Meal Plan";
            this.grpBoxDorm.ResumeLayout(false);
            this.grpBoxDorm.PerformLayout();
            this.grpboxMealPlan.ResumeLayout(false);
            this.grpboxMealPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateCost;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpBoxDorm;
        private System.Windows.Forms.RadioButton rdDrmUniversity;
        private System.Windows.Forms.RadioButton rdDrmFarthing;
        private System.Windows.Forms.RadioButton rdDrmPike;
        private System.Windows.Forms.RadioButton rdDrmAllen;
        private System.Windows.Forms.GroupBox grpboxMealPlan;
        private System.Windows.Forms.RadioButton rdMealUnlimited;
        private System.Windows.Forms.RadioButton rdMeal14;
        private System.Windows.Forms.RadioButton rdMealPlan7;
    }
}

