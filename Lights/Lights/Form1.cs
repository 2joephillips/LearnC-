using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TurnLightOn()
        {
            //Display the "light on" image.
            lightOnPictureBox.Visible = true;

            //Hide the "light off" image.
            lightOffPictureBox.Visible = false;

            //Display the light's state.
            lightStateLabel.Text = "ON";
        }

        private void TurnLightOff()
        {
            //Display the "light off" image.
            lightOffPictureBox.Visible = true;

            //Hide the "light on" image.
            lightOnPictureBox.Visible = false;

            //Display the light's state.
            lightStateLabel.Text = "OFF";
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            //Reverse the state of the light.
            if (lightOnPictureBox.Visible == true)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form. 
            this.Close();
        }
    }
}
