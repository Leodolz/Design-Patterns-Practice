using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Product
    {
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public string name { get; set; }
        public double price { get; set; }
    }
}
