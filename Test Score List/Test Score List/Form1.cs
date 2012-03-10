using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The ReadScores method reads the scores from the
        //TestScores.txt file into the scoresList parameter.
        private void ReadScores(List<int> scoresList)
        {
            try
            {
                //Open the TestScores.txt file
                StreamReader inputfile = File.OpenText("TestScores.txt");

                //Read the scores into the List.
                while (!inputfile.EndOfStream)
                {
                    scoresList.Add(int.Parse(inputfile.ReadLine()));
                }

                //Close the file.
                inputfile.Close();
            }
            catch (Exception ex)
            {
                
                //Display an Error message.
                MessageBox.Show(ex.Message);
            }
        }

        //DisplayScores method displays the contents of the 
        //scoresList parameter in the Listbox control.
        private void DisplayScores(List<int> scoresList)
        {
            foreach (int score in scoresList)
            {
                testScoresListBox.Items.Add(score);
            }
        }

        //The Average method returns the average of the values 
        //in the scoresList paramater.
        private double Average(List<int> scoresList)
        {
            int total = 0;
            double average;

            //Calculate the toatl of the scores.
            foreach (int score in scoresList)
            {
                total += score;
            }

            //Calculate the average of the scores.
            average = (double)total / scoresList.Count;

            //Return average.
            return average;
        }

        //The AboveAverage Method returns the number of 
        //above average scores in scoresList.
        private int AboveAverage(List<int> scoresList)
        {
            int numAbove = 0;

            // Get the average score.
            double avg = Average(scoresList);

            //Count the number of above average scores.
            foreach (int score in scoresList)
            {
                if (score > avg)
                {
                    numAbove++;
                }   
            }

            //Return the number above average.
            return numAbove;
        }

        //The BelowAverage method returns the number of 
        //below average scores in scoresList.
        private int BelowAverage(List<int> scoresList)
        {

            int numBelow = 0;

            //get the average score.
            double avg = Average(scoresList);

            //Count the number of below average scores.
            foreach (int score in scoresList)
            {
                if (score < avg)
                {
                    numBelow++;
                }
            }

            //Return the number of below average scores.
            return numBelow;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            double averageScore;
            int numAboveAverage;
            int numBelowAverage;

            //Create a List to hold the scores.
            List<int> scoresList = new List<int>();

            //Read the scores from the file into the list.
            ReadScores(scoresList);

            //Display the scores.
            DisplayScores(scoresList);
   
            //Display the average scores.
            averageScore = Average(scoresList);
            AverageLabel.Text = averageScore.ToString("n1");

            //Display the number of above average scores.
            numAboveAverage = AboveAverage(scoresList);
            aboveAverageLabel.Text = numAboveAverage.ToString("n1");

            //Display the number of below average scores.
            numBelowAverage = BelowAverage(scoresList);
            belowAverageLabel.Text = numBelowAverage.ToString("n1");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form. 
            this.Close();
        }
    }
}
