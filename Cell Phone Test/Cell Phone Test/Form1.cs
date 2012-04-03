using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close form.
            this.Close();
        }
        //The GetPhonedata method accepts a CellPhone object as an argument. It assigns the data enetered by the 
        //user to the object's property.
        private void GetPhoneData(Cellphone phone)
        {
            //Temporary Variable to hold the price
            decimal price;

            //Get the phone's brand. 
            phone.Brand = brandTextBox.Text;

            //Get the phone's model 
            phone.Model = modelTextBox.Text;

            //Get the phone's price 
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("Invalid Price");
            }
        }
        private void createObjectButton_Click(object sender, EventArgs e)
        {
            Cellphone myPhone = new Cellphone();

            GetPhoneData(myPhone);

            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }
    }
}
