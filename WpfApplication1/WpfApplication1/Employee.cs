using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class Employee
    {
        public Employee()
        {
            Name = "";
        }
        public Employee(string name)
        {
            Name = name;
        }
        public string Name;
    }
}
