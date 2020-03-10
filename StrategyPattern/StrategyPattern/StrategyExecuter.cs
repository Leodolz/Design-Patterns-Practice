using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StrategyExecuter
    {
        private Dictionary<string, IMoveStrategy> strategyCommands;
        public StrategyExecuter()
        {
            strategyCommands = new Dictionary<string, IMoveStrategy>
            {
                {"UP",new MoveUpwards()},
                {"DOWN",new MoveDownwards()},
                {"LEFT",new MoveLeft()},
                {"RIGHT",new MoveRight()},
                {"EXIT",new ExitProgram()}
            };
        }
        public Point ExecuteStrategy(string keyword, Point initialPosition)
        {
            if (strategyCommands.ContainsKey(keyword))
                return strategyCommands[keyword].MovePosition(initialPosition);
            else Console.WriteLine("Please enter a valid command");
            return initialPosition;
        }
    }
}
