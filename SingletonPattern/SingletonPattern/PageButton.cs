using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class PageButton : IPageItem
    {
        public void Interact()
        {
            Console.WriteLine("Clicked Button!");
        }

        public void Show()
        {
            Console.WriteLine("Showing Button");
        }
    }
}
