using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternPractice
{
    public class GenericRepositoryImp<T> : IGenericRepository<T> where T : class
    {
        private readonly EmployeeDBContext context;
        public void DeleItem(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public T GetItemById(object id)
        {
            throw new NotImplementedException();
        }

        public void InsertItem(T item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(T item)
        {
            throw new NotImplementedException();
        }
    }
}
