using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class CarFactory : AbstractVehicleFactory
    {
        public CarFactory()
        {
            availableVehicles = new Dictionary<string, Vehicle>
            {
                { "SPORT", new SportsCar() },
                { "FAMILY", new FamilyCar()}
            };
        }
    }
}
