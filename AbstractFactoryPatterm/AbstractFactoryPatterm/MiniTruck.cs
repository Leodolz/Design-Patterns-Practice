using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class MiniTruck : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving mini-Truck at 50 mph");
        }
    }
}
