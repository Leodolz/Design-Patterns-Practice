using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class PlayingState : IGameState
    {
        public void DisplayGameAudio()
        {
            Console.WriteLine("Playing game music depending on the scenario");
        }

        public void DisplayGameScreen()
        {
            Console.WriteLine("Constantly rendering game as the player moves and interacts with background");
        }

        public void HandleInputControlls(Context context, string UserInput)
        {
            Dictionary<string, IGameState> validCommands = GameCommands.PlayingCommands;
            if (validCommands.ContainsKey(UserInput))
                context.SetGameState(validCommands[UserInput]);
            else Console.WriteLine("You can't do that right now");
        }

        public void ManageCharacter()
        {
            Console.WriteLine("Handling character to control... Functionality coming soon!");
        }
    }
}
