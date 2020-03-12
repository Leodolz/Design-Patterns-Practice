using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    interface IReceiptBuilder
    {
        void SetTitle(string name);
        void AddItem(Product product);
        void SetNotes(string notes);
        Receipt GetReceipt();
    }
}
