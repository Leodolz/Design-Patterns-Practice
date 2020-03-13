using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    class CarTypeProvider
    {
        private static List<CarType> carTypes = new List<CarType>();
        public static CarType GetCarType(string brand, string color)
        {
            CarType carType = carTypes.Find(carTypeSearched => carTypeSearched.brand == brand && 
                carTypeSearched.color == color);
            if (carType != null)
                return carType;
            carType = new CarType(brand, color);
            carTypes.Add(carType);
            return carType;
        }
    }
}
