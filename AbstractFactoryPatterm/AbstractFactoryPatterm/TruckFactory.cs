using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class TruckFactory : AbstractVehicleFactory
    {
        public TruckFactory()
        {
            availableVehicles = new Dictionary<string, Vehicle>
            {
                {"MINI", new MiniTruck()},
                {"CARGO", new CargoTruck()}
            };
        }
    }
}
