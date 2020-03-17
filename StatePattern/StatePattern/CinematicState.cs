using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class CinematicState : IGameState
    {
        public void DisplayGameAudio()
        {
            Console.WriteLine("Displaying Dolby Digital 5.1 Audio");
        }

        public void DisplayGameScreen()
        {
            Console.WriteLine("Displaying Game at 1080p with better shading");
        }

        public void HandleInputControlls(Context context, string UserInput)
        {
            Dictionary<string, IGameState> validCommands = GameCommands.CinematicCommands;
            if (validCommands.ContainsKey(UserInput))
                context.SetGameState(validCommands[UserInput]);
        }

        public void ManageCharacter()
        {
            Console.WriteLine("Moving Character by Itself");
        }
    }
}
