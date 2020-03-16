using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class ActionInterpreter : IExpression
    {
        private Dictionary<string, IAction> availableActions = new Dictionary<string, IAction>();
        public static List<string> actionNames = new List<string> {"ADD","REMOVE","ESC","SHOW"};
        private List<string> editableList;
        private string editInput;
        public ActionInterpreter(List<string> editableList, string editInput)
        {
            availableActions.Add(actionNames[0], new ActionOfAdd());
            availableActions.Add(actionNames[1], new ActionOfRemove());
            availableActions.Add(actionNames[2], new ActionOfEscape());
            availableActions.Add(actionNames[3], new ActionOfShow());
            this.editableList = editableList;
            this.editInput = editInput;
        }
        public void InterpretExpression(string context)
        {
            if (availableActions.ContainsKey(context))
                if (availableActions[context].NeedsArgument() && editInput!=null)
                    availableActions[context].Execute(editableList, editInput);
                else if(!availableActions[context].NeedsArgument())
                    availableActions[context].Execute(editableList, null);
        }
    }
}
