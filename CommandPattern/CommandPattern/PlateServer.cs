using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class PlateServer : ICommand
    {
        public void Execute(Meal meal)
        {
            if(AllTasksDone(meal))
            {
                Console.WriteLine("All tasks are done, serving meal");
            }
            else
            {
                Console.WriteLine("Cannot serve, not all tasks are done");
                Undo(meal);
            }
        }

        public void Undo(Meal meal)
        {
            Console.WriteLine("Not serving yet..");
        }
        private bool AllTasksDone(Meal meal)
        {
            if (meal.cookedMeat && meal.cutIngredients && meal.mixedIngredients)
                return true;
            return false;
        }
    }
}
