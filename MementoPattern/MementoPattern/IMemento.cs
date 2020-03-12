using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    interface IMemento
    {
        GameState getGameState();
    }
}
