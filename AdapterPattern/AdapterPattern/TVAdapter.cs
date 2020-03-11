using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TVAdapter : IPCMonitor
    {
        public void displayOnPC()
        {
            Console.WriteLine("Enabling a link to TV...");
            ITVMonitor monitor = new TVDisplayer();
            monitor.displayOnTV();
        }

    }
}
