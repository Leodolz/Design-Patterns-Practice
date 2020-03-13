using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleClient singleClient = SingleClient.GetSingleClient();
            Index showingIndex = singleClient.ConnectToIndex();
            showingIndex.ShowContent();
            while (true)
            {
                Console.WriteLine("Write item ID to interact");
                showingIndex.InteractItem(Console.ReadLine());
            }
        }
    }
}
