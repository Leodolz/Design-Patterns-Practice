using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternPractice
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAllItems();
        T GetItemById(object id);
        void InsertItem(T item);
        void UpdateItem(T item);
        void DeleItem(object id);
        void Save();
    }
}
