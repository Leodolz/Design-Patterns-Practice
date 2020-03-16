using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class ActionOfRemove : IAction
    {
        public void Execute(List<string> group, string item)
        {
            if(group.Remove(item))
                Console.WriteLine(item + " removed from list");
        }

        public bool NeedsArgument()
        {
            return true;
        }
    }
}
