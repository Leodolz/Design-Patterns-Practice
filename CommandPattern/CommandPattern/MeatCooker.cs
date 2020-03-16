using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class MeatCooker : ICommand
    {
        public void Execute(Meal meal)
        {
            Console.WriteLine("Cooking meat at 300 F");
            meal.cookedMeat = true;
        }

        public void Undo(Meal meal)
        {
            Console.WriteLine("Replacing for a raw meat...");
            meal.cookedMeat = false;
        }
    }
}
