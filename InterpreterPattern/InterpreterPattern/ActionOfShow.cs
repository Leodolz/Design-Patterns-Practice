using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class ActionOfShow : IAction
    {
        public void Execute(List<string> group, string condition)
        {
            Console.WriteLine("Showing all items in group:");
            foreach(string item in group)
            {
                Console.WriteLine(item);
            }
        }

        public bool NeedsArgument()
        {
            return false;
        }
    }
}
