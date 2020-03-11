using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeController employeeController = new EmployeeController();
            employeeController.Index();
            employeeController.AddEmployee();
            employeeController.EditEmployee(2);
            employeeController.DeleteEmployee(3);
            employeeController.DeleteEmployee(10);
            employeeController.AddEmployee();
            Console.ReadLine();
        }
    }
}
