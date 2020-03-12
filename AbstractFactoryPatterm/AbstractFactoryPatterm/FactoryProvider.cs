using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    public class FactoryProvider
    {
        private static Dictionary<string, AbstractVehicleFactory> allFactories
            = new Dictionary<string, AbstractVehicleFactory> {
                { "CAR", new CarFactory()},
                { "BIKE", new BikeFactory()},
                {"TRUCK", new TruckFactory()}
            };
        public AbstractVehicleFactory returnFactory(string factoryType)
        {
            if (allFactories.ContainsKey(factoryType))
                return allFactories[factoryType];
            else return null;
        }

    }
}
