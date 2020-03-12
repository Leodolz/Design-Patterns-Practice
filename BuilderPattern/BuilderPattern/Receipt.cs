using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Receipt
    {
        public string title { get; set; }
        public List<Product> products { get; set; } = new List<Product>();
        public string notes { get; set; }
        public void PrintReceipt()
        {
            Console.WriteLine(title);
            Console.WriteLine("Products:\n-----------------------------");
            ShowTable();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Side notes: " + notes);
        }
        private void ShowTable()
        {
            double total = 0;
            foreach(Product product in products)
            {
                Console.WriteLine("Product:\t"+product.name);
                Console.WriteLine("Unit price:\t" + product.price);
                total += product.price;
            }
            Console.WriteLine("\t\tTOTAL : " + total);
        }
    }
}
