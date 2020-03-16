using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class IngredientMixer : ICommand
    {
        public void Execute(Meal meal)
        {
            Console.WriteLine("Mixing ingredients...");
            meal.mixedIngredients = true;
        }

        public void Undo(Meal meal)
        {
            Console.WriteLine("Separating ingredients");
            meal.mixedIngredients = false;
        }
    }
}
