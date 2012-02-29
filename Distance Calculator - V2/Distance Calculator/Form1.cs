using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Distance_Calculator
{
    public partial class frmDistanceCalculator : Form
    {
        public frmDistanceCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the Applicaton
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Input Variables from text box
            int mph;
            int hours;
            
            //Check for user input for File path
            if (!string.IsNullOrEmpty(lblSelectFolder.Text))
            {
                // Convert MPH text to int and assign to mph
                if (int.TryParse(txtbxMPH.Text, out mph))
                {
                    //Convert Hours Traveled to int and assign to hours
                    if (int.TryParse(txtbxHoursTraveled.Text, out hours))
                    {
                        //Declare variable for StreamWriter
                            StreamWriter outputFile;

                            //Create HomeWork file
                            outputFile = File.CreateText(lblSelectFolder.Text);

                        /* loop to calculate the distance of trip
                        it will start on the first hour and calculate distance per hour
                         till it reaches the total number of hours */
                        for (int i = 1; i <= hours; i++)
                        {
                            //Variable for distance and calculation
                            int distance = i * mph;
                            outputFile.WriteLine("After hour " + i + " the distance is " + distance);
                        }

                        //Close StreamWriter
                        outputFile.Close();
                        
                        //Display Completion of Application
                        MessageBox.Show("File created and can by located at the following path: " + lblSelectFolder.Text); 
                    }
                    else
                    {
                        //Error Message for Hours Travled Textbox
                        MessageBox.Show("Empty or Invalid number in Hours Traveled box.");
                    }
                }
                else
                {
                    //Error Message for MPH Textbox
                    MessageBox.Show("Empty or Invalid number in MPH box.");
                }
            }
            else
            {
                //File location error. 
                MessageBox.Show("Empty File Path.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Opens Folder Browser Dialog and if destination selected
                Assign path to LblSelectFolder. */
            saveFileDialog1.FileName = "Joseph Phillips HW5Ch5-2.txt";
            saveFileDialog1.Filter = "Text File | *.txt";
            if (saveFileDialog1.ShowDialog()  == DialogResult.OK)
            {

                this.lblSelectFolder.Text = saveFileDialog1.FileName;
            }
        }
    }
}
