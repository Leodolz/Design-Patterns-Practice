using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Invoker
    {
        private Meal contextMeal;
        private Stack<ICommand> commands;
        public Invoker(Meal contextMeal)
        {
            this.contextMeal = contextMeal;
            commands = new Stack<ICommand>();
        }
        public void Execute(ICommand command)
        {
            commands.Push(command);
            command.Execute(contextMeal);
        }

        public void Undo()
        {
            commands.Pop().Undo(contextMeal);
        }
    }
}
