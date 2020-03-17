using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        private IGameState gameState;
        public void SetGameState(IGameState newState)
        {
            gameState = newState;
        }
        public IGameState GetState()
        {
            return gameState;
        }
    }
}
