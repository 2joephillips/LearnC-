using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Friend_File
{
    public partial class FrmFriendFile : Form
    {
        public FrmFriendFile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void btnWriteName_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a Streamwriter Variable
                StreamWriter outputfile;

                //Append a file and get a StreamWriter Object
                outputfile = File.AppendText("Friend.txt");

                //Write Name to file
                outputfile.WriteLine(txtbxName.Text);

                //Close file
                outputfile.Close();

                //Show item was added to file
                MessageBox.Show("The name was written.");

                //Clear the txtbxName
                txtbxName.Clear();

                //Setfocus on txtbxName
                txtbxName.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

       
    }
}
