using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            AHandler recorder = new CallRecorderHandler();
            AHandler phoneWorker = new PhoneWorkerHandler();
            AHandler agentWorker = new SalesManAgentHandler();
            AHandler manager = new ExecutiveManagerHandler();
            recorder.setNextHandler(phoneWorker);
            phoneWorker.setNextHandler(agentWorker);
            agentWorker.setNextHandler(manager);
            int[] problemLevels = {0,17,8,12,3,10};
            foreach(int problemLevel in problemLevels)
            {
                recorder.HandleProblem(problemLevel);
            }
            Console.ReadLine();
        }
    }
}
