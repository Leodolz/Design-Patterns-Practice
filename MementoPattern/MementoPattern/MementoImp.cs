using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class MementoImp : IMemento
    {
        private GameState gameState;
        public MementoImp(GameState gameState)
        {
            this.gameState = gameState;
        }
        public GameState getGameState()
        {
            return gameState;
        }
    }
}
