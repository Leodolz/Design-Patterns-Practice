using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ProductReceiptBuilder : IReceiptBuilder
    {
        private Receipt receipt = new Receipt();
        public Receipt GetReceipt()
        {
            return receipt;
        }
        public void SetNotes(string notes)
        {
            receipt.notes = notes;
        }
        public void AddItem(Product product)
        {
            receipt.products.Add(product);
        }
        public void SetTitle(string name)
        {
            receipt.title = name;
        }
    }
}
