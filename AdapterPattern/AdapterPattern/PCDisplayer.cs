using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class PCDisplayer : IPCMonitor
    {
        public void displayOnPC()
        {
            Console.WriteLine("Displaying on PC");
        }
    }
}
