using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class MountainBike : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a mountain bike at 20 mph");
        }
    }
}
