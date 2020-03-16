using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    interface Iterator
    {
        object GetNext();
        object getFirst();
        object getLast();
    }
}
