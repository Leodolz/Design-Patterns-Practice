using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ExecutiveManagerHandler:AHandler
    {
        public ExecutiveManagerHandler()
        {
            lowestLevel = 11;
            highestLevel = 100;
        }
        public override void HandleProblem(int problemLevel)
        {
            base.HandleProblem(problemLevel);
        }
    }
}
