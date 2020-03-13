using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    public class CarType
    {
        public string brand { get; set; }
        public string color { get; set; }
        public CarType(string brand, string color)
        {
            Console.WriteLine("Loading Car... "+ color + "_" + brand + ".jpg");
            this.brand = brand;
            this.color = color;
        }
    }
}
