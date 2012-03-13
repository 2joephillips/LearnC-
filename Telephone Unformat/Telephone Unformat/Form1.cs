using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* The IsValidFormat method accepts a string argument and 
         * determines whether it is properly formatted as a U.S. telephone
         * number in the following manner: (XXX)XXX-XXXX
         * If the argument is properly formated, the method returns true, other
         * wise false.
         */

        private bool IsValidFormat(string str)
        {
            const int VALID_LENGTH = 13;
            bool valid;

            //Determine whether str is properly formated. 
            if (str.Length == VALID_LENGTH && str[0] == '(' &&
                str[4] == ')' && str[8] == '-')
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            //Return the value of valid. 
            return valid;
        }

        //The unformat method accepts a string, by reference, assumed to contain a 
        //telephone number formatted in this manner (XXX)XXX-XXXX.
        //This method unformats the string by removing the paren and the hyphen. 
        private void Unformat(ref string str)
        {
            //First, delete the left paren at position 0.
            str = str.Remove(0, 1);

            //Next, delete the right paren. Because of the previous deletion  it is now 
            //located at position 6.
            str = str.Remove(3, 1);

            //Next, delete the hyphen. Because of the previous deletions it is now located
            //at position 6. 
            str = str.Remove(6, 1);
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            //Get a trimmed copy of the user's input. 
            string input = numberTextBox.Text.Trim();

            //If the input is properly formated, then unformat it and display it. 
            if (IsValidFormat(input))
            {
                Unformat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                //Display an error message.
                MessageBox.Show("Invalid input.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close Form. 
            this.Close();
        }



    }
}
