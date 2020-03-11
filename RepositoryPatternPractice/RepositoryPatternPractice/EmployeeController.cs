using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternPractice
{
    class EmployeeController
    {
        private IEmployeeRepository employeeRepository;

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository(new EmployeeDBContext());
        }
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public void Index()
        {
            var model = employeeRepository.GetAll();
            ViewEmployees(model);
        }
        private void ViewEmployees(IEnumerable<Employee> employees)
        {
            Console.WriteLine("ALL EMPLOYEES:");
            Console.WriteLine("---------------------------------------");
            foreach (Employee employee in employees)
            {
                ViewEmployee(employee);
            }
            Console.WriteLine("---------------------------------------");
        }
        public void AddEmployee()
        {
            Employee newModel = new Employee();
            newModel.Name = "Generic";
            newModel.Gender = "Undefined";
            newModel.Dept = "GN";
            newModel.Salary = 10000;
            var allEmployees = employeeRepository.GetAll();
            int lastId = allEmployees[allEmployees.Count() - 1].EmployeeId;
            newModel.EmployeeId = lastId + 1;
            AddEmployee(newModel);
        }
        private void AddEmployee(Employee model)
        {
            employeeRepository.Insert(model);
            employeeRepository.Save();
            Index();
        }
        public void EditEmployee(int EmployeeId)
        {
            Employee model = employeeRepository.GetById(EmployeeId);
            ViewEmployee(model);
            model.Name = model.Name + "MOD";
            EditEmployee(model);
        }
        private void EditEmployee(Employee model)
        {
            employeeRepository.Update(model);
            employeeRepository.Save();
            Index();
        }
        public void DeleteEmployee(int EmployeeId)
        {
            Employee model = employeeRepository.GetById(EmployeeId);
            if (model == null)
                return;
            ViewEmployee(model);
            Delete(EmployeeId);
        }
        private void ViewEmployee(Employee employee)
        {
            Console.WriteLine("ID: " + employee.EmployeeId);
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Gender: " + employee.Gender);
            Console.WriteLine("Salary: " + employee.Dept);
        }
        private void Delete(int EmployeeID)
        {
            employeeRepository.Delete(EmployeeID);
            employeeRepository.Save();
            Index();
        }
    }
}
