using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class GameConsole
    {
        private Context gameContext = new Context();
        public GameConsole()
        {
            gameContext.SetGameState(GameCommands.allCommands["STOP"]);
        }
        public void HandleControlls()
        {
            ExecuteStateMethods(gameContext.GetState());
        }
        private void ExecuteStateMethods(IGameState gameState)
        {
            gameState.DisplayGameAudio();
            gameState.DisplayGameScreen();
            gameState.ManageCharacter();
            Console.WriteLine("Please enter a command");
            gameState.HandleInputControlls(gameContext,Console.ReadLine());
        }
    }
}
