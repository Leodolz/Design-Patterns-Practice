using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class FamilyCar : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Family Car at 80 mph");
        }
    }
}
