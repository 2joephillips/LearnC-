using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PerferredCustomerv2
{   

    public class Customer: Person
    {
        public int CustomerId { get; set; }
        public bool MailingList { get; set; }
    }
}
