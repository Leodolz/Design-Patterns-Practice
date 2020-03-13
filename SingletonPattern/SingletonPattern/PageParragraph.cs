using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class PageParragraph : IPageItem
    {
        private string Parragraph;
        public PageParragraph(string Parragraph)
        {
            this.Parragraph = Parragraph;
        }
        public void Interact()
        {
            Console.WriteLine("Focused on text!");
        }

        public void Show()
        {
            Console.WriteLine(Parragraph);
        }
    }
}
