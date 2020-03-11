using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class PhoneWorkerHandler:AHandler
    {
        public PhoneWorkerHandler()
        {
            lowestLevel = 6;
            highestLevel = 10;
        }
        public override void HandleProblem(int problemLevel)
        {
            base.HandleProblem(problemLevel);
        }
    }
}
