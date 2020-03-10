using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDecoratorPattern
{
    class Fries:IMeal
    {
        public List<string> ingredients { get; set; }
        public double price { get; set; }
        public Fries(List<string> ingredients, double price)
        {
            this.ingredients = ingredients;
            this.price = price;
        }
        public void DescribeAll()
        {
            Console.WriteLine("Ingredients:");
            DescribeIngredients();
            Console.Write("Price: ");
            DescribePrice();
        }

        public void DescribeIngredients()
        {
            foreach (string ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }

        public void DescribePrice()
        {
            Console.WriteLine(price + "$");
        }
    }
}
