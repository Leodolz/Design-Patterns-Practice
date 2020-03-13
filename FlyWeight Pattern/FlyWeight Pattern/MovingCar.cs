using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    public class MovingCar
    {
        public double speedMph { get; set; }
        public Point position { get; set; }
        public Point destination { get; set; }
        public CarType carType { get; set; }
        public MovingCar(double speedMph, Point position, Point destination, CarType carType)
        {
            this.speedMph = speedMph;
            this.position = position;
            this.destination = destination;
            this.carType = carType;
        }
        public void PlaceInAnimation()
        {
            Console.WriteLine(carType.color+" "+carType.brand+" at: " +
                position.ToString() + " going to " + destination.ToString() +
                " at speed of: " + speedMph + " Mph\n");
        }
    }
}
