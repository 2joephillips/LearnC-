using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Language_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            translationButton.Text = "Buenos Dias";
        }

        private void germanButton_Click(object sender, EventArgs e)
        {
            translationButton.Text = "Guten Morgen";
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            translationButton.Text = "Buogirno";
        }

       

            }
}
