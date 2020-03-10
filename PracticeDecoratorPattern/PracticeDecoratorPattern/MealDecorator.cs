using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDecoratorPattern
{
    public abstract class MealDecorator : IMeal
    {
        protected IMeal decoratedMeal;
        public MealDecorator(IMeal decoratedMeal)
        {
            this.decoratedMeal = decoratedMeal;
        }
        public abstract void DescribeAll();
        public void DescribeIngredients()
        {
            decoratedMeal.DescribeIngredients();
        }
        public void DescribePrice()
        {
            decoratedMeal.DescribePrice();
        }
    }
}
