using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class CargoTruck : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving Cargo Truck at 60 mph");
        }
    }
}
