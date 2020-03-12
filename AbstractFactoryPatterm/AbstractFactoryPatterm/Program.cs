using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatterm
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryProvider factoryProvider = new FactoryProvider();
            while (true)
            {
                string errorMessage = "Invalid argument, please try again";
                Console.WriteLine("Please enter a factory");
                string factoryName = Console.ReadLine();
                if (factoryProvider.returnFactory(factoryName) == null)
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }
                Console.WriteLine("Please enter a " + factoryName + " product: ");
                string vehicleType = Console.ReadLine();
                Vehicle desiredVehicle = factoryProvider.returnFactory(factoryName).GetVehicle(vehicleType);
                if(desiredVehicle == null)
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }
                desiredVehicle.Drive();
            }
        }
    }
}
