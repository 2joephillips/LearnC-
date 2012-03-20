using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Word_Counter
{
    public partial class frmWordCounter : Form
    {
        public frmWordCounter()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Closes the form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        /// <summary>
        /// When pressed calculates the number of words within a sentence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {   
            //Create and initalize the variable for the textbox
            string input = txtbxInput.Text;

            //Calls the method response to display the response based on 
            //what is entered into the textbox.
            MessageBox.Show(Response(input));
        }

        /// <summary>
        /// Creates a string for the btnGo_Click method.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string Response(string input)
        {
            //Checks to make sure that the textbox has inforamation in it.
            //If it is null or empty returns error message to user. 
            if(!string.IsNullOrWhiteSpace(input))    
            {
                //Creates a variable for the number of words in the sentence. 
               string numberOfWords = CountNumberOfWords(input);
                //Creates the return string.
               return "There are a total of " + numberOfWords + " word(s) in this sentence."; 
            }
            else
            {
                //Creates the return mesage for empty or null input.
                return "Enter sentence then press Go.";
            }    
        }

        /// <summary>
        ///Count the number of words. To do this, I count the number of spaces within the 
        ///input string. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string CountNumberOfWords(string input)
        {
            //Create variable for the tokens
            string[] tokens = input.Split(null);
            //Return the lenth which will be the number of words as a string.
            return tokens.Length.ToString();

        }
    }
}
