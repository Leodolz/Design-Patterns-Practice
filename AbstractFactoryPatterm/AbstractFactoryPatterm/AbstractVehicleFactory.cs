using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    public abstract class AbstractVehicleFactory
    {
        protected Dictionary<string, Vehicle> availableVehicles;
       
        public Vehicle GetVehicle(string vehicleType)
        {
            if (availableVehicles.ContainsKey(vehicleType))
                return availableVehicles[vehicleType];
            else return null;
        }
    }
}
