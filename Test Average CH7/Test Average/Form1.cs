﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //The Average method accepts an int array argument
        //and returns the average of the values in the array.
        private double Average(int[] iArray)
        {
            int total = 0; //Accumulator, initialized to 0
            double average; //To hold the average

            //Step through the array, adding each element to 
            //the accumulator.
            for (int index = 0; index < iArray.Length; index++)
            {
                total += iArray[index];
            }

            //Calculate the average.
            average = (double)total / iArray.Length;

            //Return the average
            return average;
        }

        //The Highest method accepts an int array argument
        //and returns the highest value in that array.
        private int Highest(int[] iArray) 
        {
            //Declare a variable to hold the highest value, and 
            //initialize it with the first value in the array.
            int highest = iArray[0];

            //Step through the rest of the array, beginning at 
            //element 1. When a value greater than highest is found,
            //assign that value to highest. 
            for (int index = 0; index < iArray.Length; index++)
            {
                if (iArray[index] > highest)
                {
                    highest = iArray[index];
                }
            }

            //Return the highest Value.
            return highest;
        }

        //The Lowest Method accepts an int array argument
        //and returns the lowest value in that array.
        private int Lowest(int[] iArray)
        {
            //Declare a variable to hold the lowest value, and 
            //initialize it with the first value in the array.
            int lowest = iArray[0];

            //Step through the rest of the array, beginning at 
            //element 1. When a value less than lowest is found, 
            //assign that value to lowest.
            for (int index = 0; index < iArray.Length; index++)
            {
                if (iArray[index] < lowest)
                {
                    lowest = iArray[index];
                }
            }
            
            //Return the lowest value.
            return lowest;
        }

        //test
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Local variables
                const int SIZE = 5;
                int[] scores = new int[SIZE];
                int index = 0;
                int highestScore;
                int lowestScore;
                double average;
                StreamReader inputFile;

                //Open the file and get a StreamReader object
                inputFile = File.OpenText("TestScores.txt");

                //Read the test scores into the array
                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                //Close the file.
                inputFile.Close();

                //Display the test scores.
                foreach (int value in scores)
                {
                    testScoresListBox.Items.Add(value);
                }

                //Get the highest, lowest, and average scores.
                lowestScore = Lowest(scores);
                average = Average(scores);

                //Display the values
                highScoreLabel.Text = highestScore.ToString();
                lowScoreLabel.Text = lowestScore.ToString();
                averageScoreLabel.Text = average.ToString();
            }
            catch (Exception ex)
            {
                //Display the error message
                MessageBox.Show(ex.Message);
                
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }


    }
}
