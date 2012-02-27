using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Speed_Converter
{
    public partial class frmSpeedConvertor : Form
    {
        public frmSpeedConvertor()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        private void btnDisplaySpeed_Click(object sender, EventArgs e)
        {
            //Declare Constants
            const double CONVERSION_FACTOR = 0.6214;
            const int START_SPEED = 60;
            const int FINISH_SPEED = 130;
            const int INTERVAL = 10;

            //Variables 
            int     kph;
            double  mph;

            for ( kph = START_SPEED; kph < FINISH_SPEED; kph += INTERVAL)
            {
                //Calculate miles per hour
                mph = kph * CONVERSION_FACTOR;

                lstbxOutput.Items.Add(kph + " KPH is the same as " + mph + " MPH");
            }

        }
    }
}
