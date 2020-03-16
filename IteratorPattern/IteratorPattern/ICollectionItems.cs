using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    interface ICollectionItems
    {
        Iterator GetIterator();
        void AddItem(object item);
        void RemoveItem(object item);
        object GetItem(int index);
        int Count();
    }
}
