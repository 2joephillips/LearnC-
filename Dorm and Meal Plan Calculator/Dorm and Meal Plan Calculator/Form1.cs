using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class formDormNMealPlan : Form
    {
        public formDormNMealPlan()
        {
            InitializeComponent();
        }
        

        /// <summary>
        /// Close Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close Application
            this.Close();
        }

        /// <summary>
        /// Calculate the cost of a specific Dorm and Meal Plan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            //Intialize Varaibles
            int dormCost = 0, mealPlan = 0;
            int totalcost = 0;

            //Pull value for Dorm Groupbox
            CheckGroupbox(grpBoxDorm, ref dormCost);
            //Pull value for Meal Plan
            CheckGroupbox(grpboxMealPlan, ref mealPlan);
            //Calculate Total Cost
            totalcost = dormCost + mealPlan;

            //Display Total Cost in the Total Cost forms.
            TotalCost frmTotalCost = new TotalCost();
            frmTotalCost.lblTextCost.Text = totalcost.ToString("c");
            frmTotalCost.ShowDialog();
        }

        private void CheckGroupbox(GroupBox groupbox, ref int value)
        {
            string radioText = groupbox.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
            if (groupbox.Name == "grpBoxDorm")
            {
               DormCosts(radioText, ref value);
            }
            else
            {
                MealPlanCosts(radioText, ref value);
            }

       
        }

        private void MealPlanCosts(string radioText, ref int value)
        {
            switch (radioText)
            {
                case "7 Meals":
                    value = 600;
                    break;
                case "14 Meals":
                    value = 1200;
                    break;
                case "Unlimted Meals":
                    value = 1700;
                    break;
            }
        }

        private void DormCosts(string radioText, ref int value)
        {
            switch (radioText)
            {
                case "Allen Hall": 
                    value = 1500;
                    break;
                case  "Pike Hall":
                    value = 1600;
                    break;
                case "Farthing Hall": 
                    value = 1800;
                    break;
                case  "University Suites":
                    value = 2500;
                    break;
            }
        }

      
    }
}
