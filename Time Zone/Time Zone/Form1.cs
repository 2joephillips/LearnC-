using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class frmTimeZone : Form
    {
        public frmTimeZone()
        {
            InitializeComponent();
        }

        private void brnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            //Name of City
            string city;

            if (lstbxCity.SelectedIndex !=-1)
            {
                // Get text of selected item
                city = lstbxCity.SelectedItem.ToString();

                //determine Time Zone
                switch (city)
                {
                    case "Honolulu":
                        lblTimeZone.Text = "Hawaii - Aleutian";
                        break;
                    case "San Francisco":
                        lblTimeZone.Text = "Pacific";
                        break;
                    case "Denver":
                        lblTimeZone.Text = "Mountain";
                        break;
                    case "Minneapolis":
                        lblTimeZone.Text = "Central";
                        break;
                    case "New York":
                        lblTimeZone.Text = "Eastern";
                        break;
                    default:
                        break;
                }  
            }
             else
	        {
                //No item selected in listbox
                MessageBox.Show("Select a City.");
	        }
        }        
    }
}
