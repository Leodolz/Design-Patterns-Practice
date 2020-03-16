using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Employee
    {
        public string department { get; set; }
        public string name { get; set; }
        public List<Employee> subordinates { get; set; }
        public Employee(string department, string name, List<Employee> subordinates)
        {
            this.department = department;
            this.name = name;
            this.subordinates = subordinates;
        }
        public Employee(string department, string name)
        {
            this.department = department;
            this.name = name;
            this.subordinates = new List<Employee>();
        }
    }
}
