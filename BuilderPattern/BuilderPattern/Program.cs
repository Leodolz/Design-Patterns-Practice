using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsToBuy = new List<Product>
            {
                new Product("Orange",1.25),
                new Product("CherriO's",4.49),
                new Product("Pancake Mix", 5),
                new Product("Napkin x 50",9.99)
            };
            DirectorBuilder director = new DirectorBuilder();
            Receipt receipt = director.BuildReceipt(productsToBuy, "Shop Summary", "Pay with card");
            receipt.PrintReceipt();
            Console.ReadKey();
        }
    }
}
