using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class BikeFactory : AbstractVehicleFactory
    {
        public BikeFactory()
        {
            availableVehicles = new Dictionary<string, Vehicle>
            {
                {"MOUNTAIN",new MountainBike()},
                {"URBAN", new UrbanBike()}
            };
        }
    }
}
