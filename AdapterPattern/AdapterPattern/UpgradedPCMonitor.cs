using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class UpgradedPCMonitor : IPCMonitor
    {
        private Dictionary<string, IPCMonitor> supportedFormats = 
            new Dictionary<string, IPCMonitor> {
                { "TV",new TVAdapter()},
                { "PC", new PCDisplayer() }
            };
        string wishedFormat;
        public UpgradedPCMonitor(string wishedFormat)
        {
            this.wishedFormat = wishedFormat;
        }
        public void displayOnPC()
        {
            if (supportedFormats.Keys.Contains(wishedFormat))
                supportedFormats[wishedFormat].displayOnPC();
            else Console.WriteLine("We're sorry, we don't support that kind of format");
        }
    }
}
