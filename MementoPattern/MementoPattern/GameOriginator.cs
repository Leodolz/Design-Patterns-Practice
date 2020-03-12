using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class GameOriginator
    {
        private GameState gameState;
        public GameOriginator(GameState gameState)
        {
            this.gameState = gameState;
            Console.WriteLine("Starting game at:");
            gameState.DescribeGame();
        }
        public void NextLevel()
        {
            gameState = new GameState(gameState.level + 1, gameState.userName, DateTime.Now);
        }
        public IMemento Save()
        {
            return new MementoImp(gameState);
        }
        public void RestoreGame(IMemento memento)
        {
            gameState = memento.getGameState();
            Console.WriteLine("State restored to:");
            gameState.DescribeGame();
        }
        public void DescribeCurrentLevel()
        {
            Console.WriteLine("Current level: ");
            gameState.DescribeGame();
        }
    }
}
