using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMeal burger = new Burger(new List<string> {"Tomato","Onions","Cabage","Meat","Cheese","Bread"},8.49);
            IMeal fries = new Fries(new List<string> { "Ketchup", "Potato", "Salt"}, 2.49);
            IMeal salad = new Salad(new List<string> { "Tomato", "Onions", "Cabage", "Bread" }, 5.49);
            IMeal deliveryBurger = new DeliveryMeal(burger,6.49,10);
            IMeal deliveryFries = new DeliveryMeal(fries, 4.49, 8);
            IMeal deliverySalad = new DeliveryMeal(salad, 4.49, 6);
            List<IMeal> allMeals = new List<IMeal> {burger,salad,fries,deliveryBurger,deliveryFries,deliverySalad};
            foreach(IMeal meal in allMeals)
            {
                meal.DescribeAll();
            }
            Console.ReadLine();
        }
    }
}
