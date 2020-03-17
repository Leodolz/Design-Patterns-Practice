using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IGameState
    {
        void DisplayGameScreen();
        void DisplayGameAudio();
        void ManageCharacter();
        void HandleInputControlls(Context context, string UserInput);
    }
}
