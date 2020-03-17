using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class TurnedOffState : IGameState
    {
        public void DisplayGameAudio()
        {
            Console.WriteLine("No audio");
        }

        public void DisplayGameScreen()
        {
            Console.WriteLine("Black screen");
        }

        public void HandleInputControlls(Context context, string UserInput)
        {
            Dictionary<string, IGameState> validCommands = GameCommands.TurnedOffCommands;
            if (validCommands.ContainsKey(UserInput))
                context.SetGameState(validCommands[UserInput]);
            else Console.WriteLine("Invalid input command");
        }

        public void ManageCharacter()
        {
            Console.WriteLine("No character loaded");
        }
    }
}
