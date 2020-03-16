using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    interface IAction
    {
        void Execute(List<string> group, string condition);
        bool NeedsArgument();
    }
}
