using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The GetFileName method gets a filename from the 
        //user and assigns it to the variable passed as 
        //an argument.
        private void GetFileName(out string selectedFile)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFile.FileName;
            }
            else
            {
                selectedFile = "";
            }
        }

        //The GetCountries method accpets a filename as an 
        //argument. It opens the specified file and displays
        //its contents in the countryListBox control.
        private void GetCountries(string filename)
        {
            try
            {
                //Declare a variable to hold a country name.
                string countryName;

                //Declare a StreamReader variable.
                StreamReader inputfile;

                // Open the file and get a StreamReader object.
                inputfile = File.OpenText(filename);

                //Clear anything currently in the ListBox.
                countriesListBox.Items.Clear();

                //Read the file's contents
                while (!inputfile.EndOfStream)
                {
                    //Get a country name.
                    countryName = inputfile.ReadLine();

                    //Add the country name to the ListBox.
                    countriesListBox.Items.Add(countryName);
                }

                //close the file.
                inputfile.Close();
            }
            catch (Exception ex) 
            {
              //Display the error message
                MessageBox.Show(ex.Message);
            }
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            String filename; //To hold the filename

            //Get the filename from the user.
            GetFileName(out filename);

            //Get the countries from the file.
            GetCountries(filename);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
