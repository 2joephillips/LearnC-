using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Create an array to hold the numbers.
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            //Create a Random Object
            Random rand = new Random();

            //Fill the array with random numbers, in the Range
            //0 to 99.
            for (int index = 0; index < SIZE; index++)
            {
                lotteryNumbers[index] = rand.Next(100);
            }

            //Display the array elements in the Label controls.
            firstLabel.Text = lotteryNumbers[0].ToString();
            secondLabel.Text = lotteryNumbers[1].ToString();
            thirdLabel.Text = lotteryNumbers[2].ToString();
            fourthLabel.Text = lotteryNumbers[3].ToString();
            fifthLabel.Text = lotteryNumbers[4].ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
