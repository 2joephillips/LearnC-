using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Class
{
    public partial class frmEmployeeList : Form
    {
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            //Clear Listbox
            lstbxEmployees.Items.Clear();
        }

        private void btnDisplayEmployees_Click(object sender, EventArgs e)
        {
            lstbxEmployees.Items.Clear();

            //Create three objects for each employee
            Employee employee = new Employee(47899, "Susan Meyers", "Accounting", "Vice President");
            Employee employee1 = new Employee(39119, "Mark Jones", "IT", "Programmer");
            Employee employee2 = new Employee(81774, "Joy Rogers", "Manufacturing", "Engineer");

            lstbxEmployees.Items.Add(employee.getInfo());
            lstbxEmployees.Items.Add(employee1.getInfo());
            lstbxEmployees.Items.Add(employee2.getInfo());
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }


    }
}
