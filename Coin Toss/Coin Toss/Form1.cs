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
    public partial class frmCoinToss : Form
    {
        public frmCoinToss()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            //The sideUp will indicate which side is up.
            int sideUp;

            //Create a Random Object
            Random rand = new Random();

            //Get a random integer in the range of 0 through 1. 
            //0 means tails, 1 means heads
            sideUp = rand.Next(2);

            //Display the side that is up.
            if (sideUp == 0)
            {   
                //Display tails up.
                picboxHeads.Visible = false;
                picbxTails.Visible = true;
            }
            else
            {
                //Display Heads
                picboxHeads.Visible = true;
                picbxTails.Visible =  false;
            }
        }
    }
}
