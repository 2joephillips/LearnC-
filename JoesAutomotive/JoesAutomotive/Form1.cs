/* Joe Automotive Application
 * Applicaiton will display the total for a customers' visit to Joe's Automotive.
 * 
 * Created by: Joseph PHillips
 * Must contain methods -
 * OilLubeCharges, FlushCharges, MiscCharges, OtherCharges, TaxCharges, TotalCharges
 * ClearOilLube, ClearFlushes, ClearMisc, ClearOther, ClearFees
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JoesAutomotive
{
    public partial class frmAutomotive : Form
    {
        public frmAutomotive()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Application 
            this.Close();
        }
         
        private void btnClear_Click(object sender, EventArgs e)
        {
            //call methods to clear all inputs on form
            ClearOilLube(); // Clear OilLube group
            ClearFlushes(); // Clear Flushes group
            ClearMisc(); // Clear Misc group
            ClearOther(); // Clear Other Fees group
            ClearFees(); //Clear Summary group
        }

       /// <summary>
       /// This clears all textboxes and checkboxes from a Option Group 
       /// </summary>
       /// <param name="parent"></param>
        public void ClearCheckBoxAndTextBoxConrols(Control parent)
        {
           //Loops there all the controls within a groupbox revewing each control
            foreach (Control control in parent.Controls)
            {
                //Checkbox controls are reset 
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                //Textbox controls are cleared of any text
                else if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
             }
        }

        /// <summary>
        /// Clear OilLube Group
        /// </summary>
        private void ClearOilLube()
        {
            ClearCheckBoxAndTextBoxConrols(grpbxOil_Lube);
        }

       /// <summary>
       /// Clear Flushes Group
       /// </summary>
        private void ClearFlushes()
        {
            ClearCheckBoxAndTextBoxConrols(grpbxFlushes);
        }

        /// <summary>
        /// Clear Misc Group
        /// </summary>
        private void ClearMisc()
        {
            ClearCheckBoxAndTextBoxConrols(grpbxMisc);
        }

        /// <summary>
        /// Clear Other Group
        /// </summary>
        private void ClearOther()
        {
            ClearCheckBoxAndTextBoxConrols(grpbxParts_Labor);
        }

        /// <summary>
        /// Clear Fees Group
        /// </summary>
        private void ClearFees()
        {
            lblParts.Text = "";
            lblService_Labor.Text = "";
            lblTax.Text = "";
            lblTotalFees.Text = "";
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            //Check to make sure the textboxes are valid
            if (CheckTextBoxes())
            {
                
                double otherCharges = OtherCharges(); // Calls method to calculate Other Group Charges
                double oilLubeCharges = OilLubeCharges(); // Calls method to calculate Oil and Lube Group Charges
                double flushCharges = FlushCharges(); // Calls method to caclulate Flush Group Charges
                double miscCharges = MiscCharges(); // Calls method to calculate Misc Group Charges
                double taxCharges = TaxCharges(); // Call method to calculate Tax
                double laborCharges = LaborCharges(); // Call Method for Labor Charges

                //Assign Total Service and Labor Charges to Lable
                lblService_Labor.Text = TotalCharges(oilLubeCharges, flushCharges, miscCharges, laborCharges);

                //Assign Total Fees to Lable
                lblTotalFees.Text = TotalCharges(oilLubeCharges, flushCharges, miscCharges, otherCharges, taxCharges);
             }
            // Invalid input in textboxes following message will show
            else
            {
                MessageBox.Show("Check values in Labor and Parts field.");
            }
                        
        }

        /// <summary>
        /// Checks textbox for Labor and Parts to make sure they are valid numbers
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            double labor, parts;
            bool boolLabor = true; //retun variable
            bool boolParts = true; //return variable
            //Checks to make sure something is entered by user in either textbox
            if (!string.IsNullOrWhiteSpace(txtbxParts.Text)) // !string.IsNullOrWhiteSpace(txtbxLabor.Text)) 
                boolParts = (double.TryParse(txtbxParts.Text, out parts)); //Checks to make sure input is valid
           
            if (!string.IsNullOrWhiteSpace(txtbxLabor.Text)) // !string.IsNullOrWhiteSpace(txtbxLabor.Text)) 
                boolLabor = (double.TryParse(txtbxLabor.Text, out labor)); //Checks to make sure input is valid
            
            return (boolParts && boolLabor);
        }

        /// <summary>
        /// Totals Labor and Services and returns value as a string
        /// </summary>
        /// <param name="oilLubeCharges"></param>
        /// <param name="flushCharges"></param>
        /// <param name="miscCharges"></param>
        /// <param name="laborCharges"></param>
        /// <returns></returns>
        private string TotalCharges(double oilLubeCharges, double flushCharges, double miscCharges, double laborCharges)
        {
            double dbltotal = oilLubeCharges + flushCharges + miscCharges + laborCharges;
            string strTotal = dbltotal.ToString("c");
            return strTotal;
        }

        /// <summary>
        /// Totals all fees and returns value as string
        /// </summary>
        /// <param name="oilLubeCharges"></param>
        /// <param name="flushCharges"></param>
        /// <param name="miscCharges"></param>
        /// <param name="otherCharges"></param>
        /// <param name="taxCharges"></param>
        /// <returns></returns>
        private string TotalCharges(double oilLubeCharges, double flushCharges, double miscCharges, double otherCharges, double taxCharges)
        {
            double dbltotal = oilLubeCharges + flushCharges + miscCharges + otherCharges + taxCharges;
            string strTotal = dbltotal.ToString("c");
            return strTotal;
        }

        /// <summary>
        /// Calculates the tax based on the Parts
        /// </summary>
        /// <returns></returns>
        private double TaxCharges()
        {
            const double TAXRATE = .06; 
            double partCosts = 0 ;
            if(!string.IsNullOrWhiteSpace(txtbxParts.Text))
            partCosts = double.Parse(txtbxParts.Text);

            partCosts *= TAXRATE;
            lblTax.Text = partCosts.ToString("c");
            return partCosts;
        }

        /// <summary>
        /// Calculates the total costs of Labor Charges and Part Charges
        /// </summary>
        /// <returns></returns>
        private double OtherCharges()
        {
            double laborCosts = LaborCharges(); // Calls method to Calculate Labor Charges
            double partCosts = PartCharges(); // Calls method to Calculate Part Charges
            double charges;
            return charges = laborCosts + partCosts;  
        }

        /// <summary>
        /// Returns the value of Part textbox and inserts the value in the Lable for Parts
        /// </summary>
        /// <returns></returns>
        private double PartCharges()
        {
            double partCosts = 0;
            if (!string.IsNullOrWhiteSpace(txtbxParts.Text))
            partCosts = double.Parse(txtbxParts.Text);

            lblParts.Text = partCosts.ToString("c");
            return partCosts;
        }

        /// <summary>
        /// Returns the value of Labor textbox
        /// </summary>
        /// <returns></returns>
        private double LaborCharges()
        {
            double laborCosts = 0;
            if (!string.IsNullOrWhiteSpace(txtbxLabor.Text))
            laborCosts = double.Parse(txtbxLabor.Text);

            return laborCosts;
        }

        /// <summary>
        /// Calculates the total from the Misc Group and returns value
        /// </summary>
        /// <returns></returns>
        private double MiscCharges()
        {
            double charges = 0;
            double inspectionPrice = 15.00;
            double replaceMufflerPrice = 100.00;
            double tireRotationPrice = 20.00;

            if (chkbxInspection.Checked == true)
            {
                charges += inspectionPrice;
            }
            if (chkbxReplaceMuffler.Checked == true)
            {
                charges += replaceMufflerPrice;
            }
            if (chkbxTireRotation.Checked == true)
            {
                charges += tireRotationPrice;
            }

            return charges;
        }

        /// <summary>
        /// Calculates the total from the Flush Group and returns value
        /// </summary>
        /// <returns></returns>
        private double FlushCharges()
        {
            double charges = 0;
            double radiatorFlush = 30.00;
            double transmissionFlush = 80.00;
            
            if (chkbxRadiatorFlush.Checked == true)
            {
                charges += radiatorFlush;
            }
            if (chkbxTransmissionFlush.Checked == true)
            {
                charges += transmissionFlush;
            }

            return charges;
        }

        /// <summary>
        /// Calculates the total from the Oil and Lube Group and returns value
        /// </summary>
        /// <returns></returns>
        private double OilLubeCharges()
        {
            double charges = 0;
            double oilChange = 26.00;
            double lubeJob = 18.00;

            if (chkbxOilChange.Checked == true)
            {
                charges += oilChange;
            }
            if (chkbxLubeJob.Checked == true)
            {
                charges += lubeJob;
            }

            return charges;
        }     
    }
}
