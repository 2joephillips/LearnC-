using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Orion_Constellation
{
    public partial class orionConstellationForm : Form
    {
        public orionConstellationForm()
        {
            InitializeComponent();
        }
        // Close the Applicaiton
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
         
        }
        /* This will recieve a variable of True or False. With the variable it will set the 
         star names as visable or not visible*/ 

        private void showOrHide(Boolean trueOrFalse)
        {
            betelgeuseLabel.Visible = trueOrFalse;
            meissaLabel.Visible = trueOrFalse;
            alnilamLabel.Visible = trueOrFalse;
            alnitakLabel.Visible = trueOrFalse;
            mintakaLabel.Visible = trueOrFalse;
            saiphLabel.Visible = trueOrFalse;
            rigelLabel.Visible = trueOrFalse;
        }

        private void showStarNamesButton_Click(object sender, EventArgs e)
        {
            showOrHide(true); // Shows all the stars names
        }

        private void hideStarNamesButton_Click(object sender, EventArgs e)
        {
            showOrHide(false); // Hides all the star names
        }
    }
}
