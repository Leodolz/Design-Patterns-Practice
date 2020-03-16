using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class ActionOfEscape : IAction
    {
        public void Execute(List<string> group, string condition)
        {
            Environment.Exit(0);
        }

        public bool NeedsArgument()
        {
            return false;
        }
    }
}
