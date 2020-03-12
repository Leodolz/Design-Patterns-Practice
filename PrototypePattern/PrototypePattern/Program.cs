using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TablesCache.LoadProductsCache();
            ProductTable cleanBundle = TablesCache.getFixedTable("CLEAN");
            ProductTable partyBundle = TablesCache.getFixedTable("PARTY");
            ProductTable valentineBundle = TablesCache.getFixedTable("VALENTINE");
            ShowBundle(partyBundle);
            ShowBundle(valentineBundle);
            ShowBundle(cleanBundle);
            cleanBundle.products.Add(new Product("Ultra Cleaner", 18.99));
            cleanBundle.name = "ULTRA CLEAN BUNDLE";
            ShowBundle(cleanBundle);
            Console.ReadKey();
        }
        private static void ShowBundle(ProductTable Bundle)
        {
            Console.WriteLine(Bundle.name);
            Console.WriteLine("------------------------");
            foreach (Product product in Bundle.products)
            {
                Console.WriteLine("Product name: " + product.name);
                Console.WriteLine("Product price: " + product.price);
            }
            Console.WriteLine("------------------------");
        }
    }
}
