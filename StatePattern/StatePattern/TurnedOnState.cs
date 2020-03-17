using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class TurnedOnState : IGameState
    {
        public void DisplayGameAudio()
        {
            Console.WriteLine("Playing opening music");
        }

        public void DisplayGameScreen()
        {
            Console.WriteLine("Displaying title screen");
        }

        public void HandleInputControlls(Context context, string UserInput)
        {
            Dictionary<string, IGameState> validCommands = GameCommands.allCommands;
            if (validCommands.ContainsKey(UserInput))
                context.SetGameState(validCommands[UserInput]);
            else Console.WriteLine("Invalid input command");
        }

        public void ManageCharacter()
        {
            Console.WriteLine("Managing title options to play game... Functionality coming soon");
        }
    }
}
