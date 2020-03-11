using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternPractice
{
    interface IEmployeeRepository
    {
        IList<Table> GetAll();
        Table GetById(int EmployeeID);
        void Insert(Table employee);
        void Update(Table employee);
        void Delete(int EmployeeID);
        void Save();
    }
}
