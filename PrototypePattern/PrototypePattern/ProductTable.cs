using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class ProductTable:ICloneable
    {
        public string name { get; set; }
        public List<Product> products { get; set; }
        public ProductTable()
        {
            products = new List<Product>();
        }
        public object Clone()
        {
            //return Clone();
            return this.MemberwiseClone() as ProductTable;
        }
    }
}
