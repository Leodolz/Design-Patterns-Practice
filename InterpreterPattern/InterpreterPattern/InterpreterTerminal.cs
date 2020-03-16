using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class InterpreterTerminal : IExpression
    {
        private List<string> userList = new List<string>();
        private List<string> validCommands = ActionInterpreter.actionNames;
        public void InterpretExpression(string context)
        {
            foreach (string validCommand in validCommands)
            {
                if (context.StartsWith(validCommand))
                    SendAction(context);
                
            }
        }
        private void SendAction(string context)
        {
            if (context.Split(' ').Length > 1)
            {
                ActionInterpreter actionInterpreter = new ActionInterpreter(userList, context.Split(' ')[1]);
                actionInterpreter.InterpretExpression(context.Split(' ')[0]);
            }
            else
            {
                ActionInterpreter actionInterpreter = new ActionInterpreter(userList, null);
                actionInterpreter.InterpretExpression(context.Split(' ')[0]);
            }
        }
    }
}
