using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cell_Phone_Test
{
    class Cellphone
    {
        //Fields
        private string _brand;
        private string _model;
        private decimal _price;

        //Constructure
        public Cellphone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        //Brand Property
        public string Brand
        {
            get {return _brand;}
            set {_brand = value;}
        }

        //Model Property
        public string Model
        {
            get {return _model;}
            set {_model = value;}
        }

        //Price Property 
        public decimal Price
        {
            get {return _price;}
            set {_price = value;}
        }
    }
}
