using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern
{
    class NotUsedCar
    {
        //THIS CLASS IS NOT USED
        //THIS IS TO ILUSTRATE THE BENEFITS OF FLYWEIGHT PATTERN
        public string brand { get; set; }
        public string color { get; set; }
        public double speedMph { get; set; }
        public Point position { get; set; }
        public Point destination { get; set; }
        
    }
}
