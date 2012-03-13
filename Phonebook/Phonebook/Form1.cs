using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{

    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }


    public partial class Form1 : Form
    {
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        //The ReadFile method reads the contents of the PhoneList.txt file and 
        // and stores it as PhoneBookEntry objects in the phonelist.
        private void ReadFile()
        {
            try
            {
                StreamReader inputfile;
                string line;

                //Create an instance of the PhoneBookEntry structure. 
                PhoneBookEntry entry = new PhoneBookEntry();

                //Create a delimiter array. 
                char[] delim = { ',' };

                //Open the PhoneList file.
                inputfile = File.OpenText("PhoneList.txt");

                //Read the lines from the file.
                while (!inputfile.EndOfStream)
                {
                    //Read a line from the file.
                    line = inputfile.ReadLine();

                    //Tokenize the line.
                    string[] tokens = line.Split(delim);
                    
                    //Store the tokens in the entry object. 
                    entry.name = tokens[0];
                    entry.phone = tokens[1};

                    //Add the entry object to the List.
                    phoneList.Add(entry);    
                }
      
            catch (Exception ex)
            {
                //Display Error Message.
                MessageBox.Show(ex.Message);
            }
        }

        //The DisplayNames method displays the list of names in the 
        //names in then nameslistbox.
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read the PhoneList.txt file.
            ReadFile();

            //Display the names.
            DisplayNames();
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the index of the selected items. 
            int index = nameListBox.SelectedIndex;

            //Display the corresponding phone number.
            phoneLabel.Text = phoneList[index].phone;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close form.
            this.Close();
        }
    } 
}

