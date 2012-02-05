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
            lblNameFormatter.Text = "1";
        }

        private void btnFormat2_Click(object sender, EventArgs e)
        {
            lblNameFormatter.Text = "2";
        }

        private void btnFormat3_Click(object sender, EventArgs e)
        {
            lblNameFormatter.Text = "3";
        }

        private void btnFormat4_Click(object sender, EventArgs e)
        {
            lblNameFormatter.Text = "4";
        }

        private void btnFormat5_Click(object sender, EventArgs e)
        {
            lblNameFormatter.Text = "5";
        }
        
        private void btnFormat6_Click(object sender, EventArgs e)
        {
            lblNameFormatter.Text = "6";
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
