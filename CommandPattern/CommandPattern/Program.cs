using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Meal hamburger = new Meal();
            Invoker mealCooker = new Invoker(hamburger);
            mealCooker.Execute(new VegetableCutter());
            mealCooker.Execute(new IngredientMixer());
            mealCooker.Undo();
            mealCooker.Execute(new MeatCooker());
            mealCooker.Execute(new IngredientMixer());
            mealCooker.Execute(new PlateServer());
            mealCooker.Undo();
            mealCooker.Undo();
            mealCooker.Execute(new PlateServer());
            Console.ReadKey();
        }
    }
}
