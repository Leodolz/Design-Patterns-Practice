using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Point initialPoint = new Point(0, 0);
            StrategyExecuter executer = new StrategyExecuter();
            while (true)
            {
                Console.WriteLine("Point X: " + initialPoint.X + " Y: " + initialPoint.Y);
                initialPoint = executer.ExecuteStrategy(Console.ReadLine(), initialPoint);
            }
        }
    }
}
