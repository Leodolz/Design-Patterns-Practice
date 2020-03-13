using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    public class CarAnimator
    {
        private List<MovingCar> movingCars = new List<MovingCar>();
        public void PlaceNewCar(Point position, Point destination, double speed, string brand, string color)
        {
            CarType carType = CarTypeProvider.GetCarType(brand, color);
            MovingCar movingCar = new MovingCar(speed, position, destination, carType);
            movingCars.Add(movingCar);
        }
        public void LoadDerbyAnimation()
        {
            foreach(MovingCar movingCar in movingCars)
            {
                movingCar.PlaceInAnimation();
            }
        }
        
    }
}
