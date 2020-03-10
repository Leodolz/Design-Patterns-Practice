using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDecoratorPattern
{
    class DeliveryMeal : MealDecorator
    {
        double deliveryPrice;
        double deliveryMinTime;
        public DeliveryMeal(IMeal decoratedMeal, double deliveryPrice, double deliveryMinTime)
            : base(decoratedMeal)
        {
            this.deliveryMinTime = deliveryMinTime;
            this.deliveryPrice = deliveryPrice;
        }
        public override void DescribeAll()
        {
            decoratedMeal.DescribeAll();
            Console.Write("Delivery time: ");
            DescribeDeliveryTime();
            Console.Write("Delivery price: ");
            DescribeDeliveryPrice();
        }
        private void DescribeDeliveryTime()
        {
            Console.WriteLine(deliveryMinTime+" min");
        }
        private void DescribeDeliveryPrice()
        {
            Console.WriteLine(deliveryPrice + " $");
        }
    }
}
