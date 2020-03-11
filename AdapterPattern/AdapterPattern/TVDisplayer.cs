using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class TVDisplayer : ITVMonitor
    {
        public void displayOnTV()
        {
            Console.WriteLine("Displaying on TV");
        }
    }
}
