using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PerferredCustomerv2
{
    public partial class Sales : Form
    {
        public List<PerferredCustomer> perCustomers = new List<PerferredCustomer>();
        public Sales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCustomer frmCreateCustomer = new CreateCustomer();
            frmCreateCustomer.ShowDialog();
        }


    }
}
