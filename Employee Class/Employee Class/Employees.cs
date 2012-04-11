using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Class
{
    class Employee
    {
        
        public string Name { get; set; }
        private int IdName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public Employee (int id, string name, string department, string position)
        {
            IdName = id;
            Name = name;
            Department = department;
            Position = position;

        }

        public Employee()
        {
            IdName = 0;
            Name = "";
            Department = "";
            Position = "";
        }
        public Employee(int id, string name)
        {
            IdName = id;
            Name = name;
            Department = "";
            Position = "";
        }

        public string getInfo()
        {
             return IdName.ToString() + " " + Name.ToString();
        }
    }
}
