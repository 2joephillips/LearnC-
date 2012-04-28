using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            NewAccount frmNewAccount = new NewAccount();
            frmNewAccount.Visible = true;
        }
    }
}
