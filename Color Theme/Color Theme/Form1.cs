using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void rdbtnYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnYellow.Checked)
            {
                //Close Form
                this.BackColor = Color.Yellow;
            }
        }

        private void rdbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRed.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void rdbtnWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnWhite.Checked)
            {
                this.BackColor = Color.White;
            }
        }

        private void rdbtnBackToNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnBackToNormal.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

     }
}
