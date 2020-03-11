using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class SalesManAgentHandler:AHandler
    {
        public SalesManAgentHandler()
        {
            lowestLevel = 11;
            highestLevel = 15;
        }
        public override void HandleProblem(int problemLevel)
        {
            base.HandleProblem(problemLevel);
        }
    }
}
