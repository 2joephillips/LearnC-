using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Birthdate_String
{
    public partial class BirthDateForm : Form
    {
        public BirthDateForm()
        {
            InitializeComponent();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            //Decalare output variable
            string output;

            //Concatenate the input from the textboxes and build the output
            output = txtbxDayofWeek.Text + ", " + txtbxMonth.Text + " " + txtbxDayofMonth.Text + "," +
                txtbxYear.Text;

            //Display output
            lblDateOutput.Text = output;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear Textboxes
            txtbxDayofMonth.Text = "";
            txtbxDayofWeek.Text = "";
            txtbxMonth.Text = "";
            txtbxYear.Text = "";
        
            //Clear lable for output
            lblDateOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
    }
}
