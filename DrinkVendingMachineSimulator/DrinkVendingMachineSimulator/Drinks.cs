using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkVendingMachineSimulator
{
    class Drinks
    {
        /// <summary>
        /// used to store the Description of Drink
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// used to store the Quanity of drink
        /// </summary>
        public int Quantity {get; set;}
        /// <summary>
        /// Used to store the Price of the drink
        /// </summary>
        public decimal Price {get;set;}
        
        /// <summary>
        /// Recduce the quanity of a drink within a list of Drinks.
        /// </summary>
        /// <param name="TypeDrink"></param>
        /// <param name="Drinks"></param>
        public void ReduceQuantity(string TypeDrink, ref List<Drinks> Drinks)
        {

            Drinks drink = new Drinks();
            drink = Drinks.Find(p => p.Description == TypeDrink);
            drink.Quantity--;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Drinks()
        {
            Description = "";
            Quantity = 20;
            Price = 0m;
        }

        /// <summary>
        /// Add Drink to a list<drinks>
        /// </summary>
        /// <param name="description"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        /// <param name="VendingMachine"></param>
        public void LoadVendingMachine(string description, int quantity, decimal price, ref List<Drinks> VendingMachine)
        {
            Drinks Drink = new Drinks();
            Drink.Description = description;
            Drink.Quantity = quantity;
            Drink.Price = price;
            VendingMachine.Add(Drink);
        }

        /// <summary>
        /// Used to return the quantity of drinks as a string.
        /// </summary>
        /// <param name="typeDrink"></param>
        /// <param name="Drinks"></param>
        /// <returns></returns>
        public string QuantityOfDrinks(string typeDrink, List<Drinks> Drinks)
        {
            Drinks drink = new Drinks();
            drink = Drinks.Find(p => p.Description == typeDrink);
            return drink.Quantity.ToString();
        }
    }
}
