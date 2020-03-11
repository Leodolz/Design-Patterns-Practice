using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class CallRecorderHandler : AHandler
    {
        public CallRecorderHandler()
        {
            lowestLevel = 0;
            highestLevel = 5;
        }
        public override void HandleProblem(int problemLevel)
        {
            base.HandleProblem(problemLevel);
        }
    }
}
