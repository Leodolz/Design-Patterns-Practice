using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class ActionOfAdd : IAction
    {
        public void Execute(List<string> group, string adition)
        {
            group.Add(adition);
            Console.WriteLine(adition+" added to list");
        }

        public bool NeedsArgument()
        {
            return true;
        }
    }
}
