using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //Create a Coin Object
            Coin myCoin = new Coin();

            //Clear the listbox.
            outputListBox.Items.Clear();

            //Toss the coin five times. 
            for (int count = 0; count < 5; count++)
            {
                myCoin.Toss();
                //Display the side that is up. 
                outputListBox.Items.Add(myCoin.GetSideUp());
            } 
        }
    }
}
