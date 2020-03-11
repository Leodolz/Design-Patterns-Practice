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
            Table employee = context.Tables.Find(EmployeeID);
            context.Tables.Remove(employee);
        }

        public IList<Table> GetAll()
        {
            return context.Tables.ToList();
        }

        public Table GetById(int EmployeeID)
        {
            return context.Tables.Find(EmployeeID);
        }

        public void Insert(Table employee)
        {
            context.Tables.Add(employee);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Table employee)
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
