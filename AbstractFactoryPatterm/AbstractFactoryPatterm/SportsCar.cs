using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class SportsCar : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a sports car at 120 mph");
        }
    }
}
