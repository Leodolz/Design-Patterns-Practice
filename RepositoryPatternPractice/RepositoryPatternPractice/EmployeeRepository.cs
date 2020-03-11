using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternPractice
{
    class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext context;
        public EmployeeRepository()
        {
            context = new EmployeeDBContext();
        }
        public EmployeeRepository(EmployeeDBContext context)
        {
            this.context = context;
        }
        public void Delete(int EmployeeID)
        {
            Employee employee = context.Employees.Find(EmployeeID);
            context.Employees.Remove(employee);
        }

        public IList<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetById(int EmployeeID)
        {
            return context.Employees.Find(EmployeeID);
        }

        public void Insert(Employee employee)
        {
            context.Employees.Add(employee);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            context.Entry(employee).State = System.Data.Entity.EntityState.Modified;
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if (disposing)
                    context.Dispose();
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
