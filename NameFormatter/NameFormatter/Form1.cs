using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NameFormatter
{
    public partial class FrmNameFormatter : Form
    {
           //Variables for Textboxes
        string FName, LName, MName,Title;

        public FrmNameFormatter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFormat1_Click(object sender, EventArgs e)
        {
            pullVariable();
            lblNameFormatter.Text = Title + " " + FName + " " + MName + " " + LName;
        }

        private void btnFormat2_Click(object sender, EventArgs e)
        {
            pullVariable();
            lblNameFormatter.Text = FName + " " + MName + " " + LName;
        }

        private void btnFormat3_Click(object sender, EventArgs e)
        {
            pullVariable();
            lblNameFormatter.Text = FName + " " + LName;
        }

        private void btnFormat4_Click(object sender, EventArgs e)
        {
            pullVariable();
            lblNameFormatter.Text = LName + ", " + FName + " " + MName + ", " + Title;
        }

        private void btnFormat5_Click(object sender, EventArgs e)
        {
            pullVariable();
            lblNameFormatter.Text = LName + ", " + FName + " " + MName;
        }
        
        private void btnFormat6_Click(object sender, EventArgs e)
        {
            pullVariable();
            lblNameFormatter.Text = LName + ", " + FName;
        }

        private void pullVariable()
        {
            FName = txtFName.Text;
            LName = txtLName.Text;
            MName = txtMName.Text;
            Title = txtTitle.Text;
        }



    }
}
