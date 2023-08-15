using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N24Task2
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public byte Kpi { get; set; }

        public Employee(string firstName, string lastName, double salary, byte kpi)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Kpi = kpi;
        }
    }
}
