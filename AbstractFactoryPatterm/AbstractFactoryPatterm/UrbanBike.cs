using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class UrbanBike : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving urban bike at 10 mph");
        }
    }
}
