using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class EmployeesCollection : ICollectionItems
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee("CEO","Luke", new List<Employee>
            {
                new Employee("Jainitor","James"),
                new Employee("GeneralManager","Dean",new List<Employee>
                {
                        new Employee("Salesman","Lance",new List<Employee>
                    {
                        new Employee("Intern","Joel")
                    }),
                    new Employee("Salesman2","Vance", new List<Employee>
                    {
                        new Employee("Intern","Joe")
                    }),
                    new Employee("Marketing","Vincent")
                }),
                new Employee("Secretary","Janice")
            })
        };
        public void AddItem(object item)
        {
            employees.Add((Employee)item);
            Console.WriteLine(((Employee)item).name+" was hired in the company!");
        }

        public Iterator GetIterator()
        {
            return new CustomIterator(this);
        }

        public void RemoveItem(object item)
        {
            if(employees.Remove((Employee)item))
                Console.WriteLine(((Employee)item).name + " was fired from the company...");
        }

        public object GetItem(int index)
        {
            return employees[index];
        }
        public int Count()
        {
            return employees.Count;
        }

    }
}
