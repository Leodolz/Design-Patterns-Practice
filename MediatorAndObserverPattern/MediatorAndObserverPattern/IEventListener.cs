using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAndObserverPattern
{
    interface IEventListener
    {
        void update();
        string GetName();
    }
}
