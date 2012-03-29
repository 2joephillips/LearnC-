using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrinkVendingMachineSimulator
{
    public partial class Form1 : Form
    {
        //Declare List for all the drinks in the machine.
        List<Drinks> Drinks = new List<Drinks>();
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application
            this.Close();
        }

        /// <summary>
        /// On Load Fill-up the Machine with Drinks, and Display the quantity of drinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Initial value of total sales
            decimal total = 0m;
            //Load Vending Machine 
            FillUpVendingMachine(ref Drinks);
            //Update quantity values for all Drink types
            DisplayQuantityofDrinks(ref Drinks);

            lblTotalSales.Text = total.ToString("c");       
        }

        /// <summary>
        /// User purchases cola
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctrbxCola_Click(object sender, EventArgs e)
        {
           
            string drinktype = "Cola";
            UpdateVendingMachine(lblDrinksLeftCola, drinktype);
        }

        /// <summary>
        /// User Purchases Root Beer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctrbxRootBeer_Click(object sender, EventArgs e)
        {

            string drinktype = "RootBeer";
            UpdateVendingMachine(lblDrinksLeftRootBeer, drinktype);
        }

        /// <summary>
        /// User Purchases Lemon Lime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctrbxLemonLime_Click(object sender, EventArgs e)
        {

            string drinktype = "LemonLimeSoda";
            UpdateVendingMachine(lblDrinksLeftLemonLime, drinktype);
        }

        /// <summary>
        /// User Purchases Grape Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctrbxGrapeSoda_Click(object sender, EventArgs e)
        {

            string drinktype = "GrapeSoda";
            UpdateVendingMachine(lblDrinksLeftGrapeSoda, drinktype);
        }

        /// <summary>
        /// User Purchases Cream Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctrbxCreamSoda_Click(object sender, EventArgs e)
        {

            string drinktype = "CreamSoda";
            UpdateVendingMachine(lblDrinksLeftCreamSoda, drinktype);
        }

        /// <summary>
        /// Used to display the Quantity of all Drinks in machine.
        /// </summary>
        /// <param name="Drinks"></param>
        private void DisplayQuantityofDrinks(ref List<Drinks> Drinks)
        {
            Drinks Drink = new Drinks();
            lblDrinksLeftCola.Text = Drink.QuantityOfDrinks("Cola", Drinks);
            lblDrinksLeftRootBeer.Text = Drink.QuantityOfDrinks("RootBeer", Drinks);
            lblDrinksLeftLemonLime.Text = Drink.QuantityOfDrinks("LemonLimeSoda", Drinks);
            lblDrinksLeftGrapeSoda.Text = Drink.QuantityOfDrinks("GrapeSoda", Drinks);
            lblDrinksLeftCreamSoda.Text = Drink.QuantityOfDrinks("CreamSoda", Drinks);
        }

        /// <summary>
        /// Used to load the machine with all the intial values
        /// </summary>
        /// <param name="Drinks"></param>
        private void FillUpVendingMachine(ref List<Drinks> Drinks)
        {
            Drinks Drink = new Drinks();
            Drink.LoadVendingMachine("Cola", 20, 1m,ref Drinks);
            Drink.LoadVendingMachine("RootBeer", 20, 1m, ref Drinks);
            Drink.LoadVendingMachine("LemonLimeSoda", 20, 1m, ref Drinks);
            Drink.LoadVendingMachine("GrapeSoda", 20, 1.5m, ref Drinks);
            Drink.LoadVendingMachine("CreamSoda", 20, 1.5m, ref Drinks);
        }

       /// <summary>
       /// Used to update the total sales value based on specific DrinkType
       /// </summary>
       /// <param name="DrinkType"></param>
       /// <returns></returns>
        private string UpdateTotalSales(string DrinkType )
        {
            Drinks drink = new Drinks();
            //Find drink within the list of Drinks
            drink = Drinks.Find(p => p.Description == DrinkType);
            //Convert Total Sales to decimal
            decimal total = decimal.Parse(lblTotalSales.Text,System.Globalization.NumberStyles.Currency);
            //Calculate new total
            total = total + drink.Price;
            return total.ToString("c");
        }

        /// <summary>
        /// Used to update the quanity of a specific DrinkType and return string of new quantity
        /// </summary>
        /// <param name="DrinkType"></param>
        /// <returns></returns>
        private string UpdateDrinkQuantity(string DrinkType)
        {
            Drinks drink = new Drinks();
            drink.ReduceQuantity(DrinkType, ref Drinks);
            return drink.QuantityOfDrinks(DrinkType, Drinks);
        }

        /// <summary>
        /// Update the Vending Machine with a Drink is purchased.
        /// </summary>
        /// <param name="lblname"></param>
        /// <param name="drinktype"></param>
        private void UpdateVendingMachine(Control lblname, string drinktype)
        {
            //Get quantity of Drinks available
            int quantity = int.Parse(lblname.Text);
            //Check to see if drink is available
            if (quantity > 0)
            {
                //Update Vending Machine with new quantity and Total Sales
                lblname.Text = UpdateDrinkQuantity(drinktype);
                lblTotalSales.Text = UpdateTotalSales(drinktype);
            }
            else
            {
                //No Drinks display error.
                MessageBox.Show("No more drinks available");
            }

        }
     }
}