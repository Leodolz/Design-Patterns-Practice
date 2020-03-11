using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPCMonitor pcMonitor = new UpgradedPCMonitor("PC");
            pcMonitor.displayOnPC();
            pcMonitor = new UpgradedPCMonitor("TV");
            pcMonitor.displayOnPC();
            Console.ReadLine();
        }
    }
}
