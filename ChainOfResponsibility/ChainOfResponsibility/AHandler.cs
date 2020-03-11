using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class AHandler
    {
        protected AHandler nextHandler;
        protected int lowestLevel;
        protected int highestLevel;
        public void setNextHandler(AHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
        public virtual void HandleProblem(int problemLevel)
        {
            if (problemInRange(problemLevel))
                Console.WriteLine("Problem of magnitude: " + problemLevel +
                    " is solved by " + GetType().Name);
            else if (nextHandler != null)
            {
                nextHandler.HandleProblem(problemLevel);
            }
        }
        protected bool problemInRange(int problemLevel)
        {
            return (problemLevel >= lowestLevel && problemLevel <= highestLevel);
        }
    }
}
