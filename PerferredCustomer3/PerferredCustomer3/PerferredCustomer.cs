using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerferredCustomer3
{
    class PerferredCustomer : Customer
    {
        public int TotalSales { get; set; }
        public double Discount { get; set; }

        public double DiscountAmount()
        {
            if (TotalSales > 2000)
            {
                return Discount = .1;
            }
            else if (TotalSales >= 1500)
            {
                return Discount = .07;
            }
            else if (TotalSales >= 1000)
            {
                return Discount = .06;
            }
            else if (TotalSales >= 500)
            {
                return Discount = .05;
            }
            else
            {
                return Discount = 0;
            }
        }
    }
}
