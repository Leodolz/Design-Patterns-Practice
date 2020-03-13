using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Index
    {
        private static Index mainIndex = new Index();
        private Dictionary<string, IPageItem> pageItems;
        public Index()
        {
            pageItems = new Dictionary<string, IPageItem>
            {
                { "P1", new PageParragraph("Don't Click this button") },
                { "B1", new PageButton() },
                { "P2", new PageParragraph("This content is for test only\nMaking a test Parragraph") },
                { "B2", new PageButton() },
                { "B3", new PageButton() }
            };
        }
        public static Index GetIndex()
        {
            return mainIndex;
        }
        public void ShowContent()
        {
            Console.WriteLine("----------------PAGE INDEX-----------------");
            foreach(KeyValuePair<string,IPageItem> pageItem in pageItems)
            {
                pageItem.Value.Show();
            }
        }
        public void InteractItem(string itemID)
        {
            if (pageItems.ContainsKey(itemID))
                pageItems[itemID].Interact();
            else Console.WriteLine("Invalid item ID");
        }
    }
}
