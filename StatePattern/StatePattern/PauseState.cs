using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class PauseState : IGameState
    {
        public void DisplayGameAudio()
        {
            Console.WriteLine("Playing background music at low volume");
        }

        public void DisplayGameScreen()
        {
            Console.WriteLine("Displaying pause menu");
        }

        public void HandleInputControlls(Context context, string UserInput)
        {
            Dictionary<string, IGameState> validCommands = GameCommands.PauseCommands;
            if (validCommands.ContainsKey(UserInput))
                context.SetGameState(validCommands[UserInput]);
            else Console.WriteLine("You can't do that right now");
        }

        public void ManageCharacter()
        {
            Console.WriteLine("Frozen character cannot move until exiting state");
        }
    }
}
