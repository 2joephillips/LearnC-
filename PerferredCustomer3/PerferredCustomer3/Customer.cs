using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerferredCustomer3
{
    class Customer: Person
    {
        public int CustomerId { get; set; }
        public bool MailingList { get; set; }
    }
}
