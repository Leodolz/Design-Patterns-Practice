using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeesCollection employees = new EmployeesCollection();
            Iterator iterator = employees.GetIterator();
            Employee currentEmployee;
            currentEmployee = (Employee)iterator.getFirst();
            Console.WriteLine(currentEmployee.name);
            currentEmployee = (Employee)iterator.GetNext();
            Console.WriteLine(currentEmployee.name);
            currentEmployee = (Employee)iterator.GetNext();
            Console.WriteLine(currentEmployee.name);
            currentEmployee = (Employee)iterator.getLast();
            Console.WriteLine(currentEmployee.name);
            Console.ReadKey();
        }
    }
}
