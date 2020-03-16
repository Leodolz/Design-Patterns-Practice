using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class VegetableCutter : ICommand
    {
        public void Execute(Meal meal)
        {
            Console.WriteLine("Cutting vegetables for 5 min");
            meal.cutIngredients = true;
        }

        public void Undo(Meal meal)
        {
            Console.WriteLine("Throwing cut vegetables and replacing for new uncuted ones");
            meal.cutIngredients = false;
        }
    }
}
