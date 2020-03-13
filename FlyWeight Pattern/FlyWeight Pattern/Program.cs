using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarAnimator carAnimator = new CarAnimator();
            // Placing Cars with new jpgs
            LoadJpgsAndPlace(carAnimator);
            // Placing new Cars with same jpgs
            PlaceLoadedCars(carAnimator);
            carAnimator.LoadDerbyAnimation();
            Console.ReadKey();
        }
        private static void LoadJpgsAndPlace(CarAnimator carAnimator)
        {
            carAnimator.PlaceNewCar(new Point(0, 0), new Point(120, 222), 85.7, "Audi", "Red");
            carAnimator.PlaceNewCar(new Point(87, 200), new Point(120, 253), 120.14, "Mercedes", "Blue");
            carAnimator.PlaceNewCar(new Point(15, 103), new Point(0, 7), 160.52, "Mustang", "Blue");
            carAnimator.PlaceNewCar(new Point(255, 255), new Point(0, 0), 100.5, "Mercedes", "Red");
            Console.WriteLine("Loaded all jpgs...\n");
        }
        private static void PlaceLoadedCars(CarAnimator carAnimator)
        {
            carAnimator.PlaceNewCar(new Point(25, 68), new Point(100, 233), 78.65, "Audi", "Red");
            carAnimator.PlaceNewCar(new Point(10, 10), new Point(12, 250), 185, "Mustang", "Blue");
            carAnimator.PlaceNewCar(new Point(180, 2), new Point(120, 253), 125.4, "Mercedes", "Blue");
            carAnimator.PlaceNewCar(new Point(150, 17), new Point(110, 224), 60.52, "Mustang", "Blue");
            carAnimator.PlaceNewCar(new Point(100, 100), new Point(0, 0), 10.5, "Mercedes", "Red");
            carAnimator.PlaceNewCar(new Point(111, 156), new Point(100, 233), 178.65, "Audi", "Red");
        }
    }
}
