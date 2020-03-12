using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class DirectorBuilder
    {
        ProductReceiptBuilder receiptBuilder;
        public Receipt BuildReceipt(List<Product> products,string title, string sideNotes)
        {
            receiptBuilder = new ProductReceiptBuilder();
            receiptBuilder.SetTitle(title);
            receiptBuilder.SetNotes(sideNotes);
            setTable(products);
            return GetReceipt();
        }
        private Receipt GetReceipt()
        {
            return receiptBuilder.GetReceipt();
        }
        private void setTable(List<Product> products)
        {
            foreach(Product product in products)
            {
                receiptBuilder.AddItem(product);
            }
        }
    }
}
