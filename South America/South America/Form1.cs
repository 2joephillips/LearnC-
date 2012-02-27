using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variable 
                string countryName;

                //Create a StreamReader variable and object
                StreamReader inputfile = File.OpenText("Countries.txt");

                //Clear out listbox
                countriesListBox.Items.Clear();

                //Read the files contents
                while (! inputfile.EndOfStream)
                {
                    //Get name of country
                    countryName = inputfile.ReadLine();

                    //Add Name to Listbox
                    countriesListBox.Items.Add(countryName);

                }
                //Close file
                inputfile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
