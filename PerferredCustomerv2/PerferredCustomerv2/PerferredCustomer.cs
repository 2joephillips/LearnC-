using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerferredCustomerv2
{
    public class PerferredCustomer: Customer
    {
        public int TotalSales { get; set; }
        public decimal discount { get; set; }
    }
}
