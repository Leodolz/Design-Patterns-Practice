using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public static class GameCommands
    {
        public static Dictionary<string, IGameState> allCommands = new Dictionary<string, IGameState>
        {
            {"CINEMATIC", new CinematicState()},
            {"START", new TurnedOnState()},
            {"STOP", new TurnedOffState()},
            {"PAUSE", new PauseState()},
            {"PLAY", new PlayingState()}
        };
        public static Dictionary<string, IGameState> CinematicCommands = new Dictionary<string, IGameState>
        {
            {"PLAY", allCommands["PLAY"]},
            {"PAUSE", allCommands["PAUSE"] },
            {"STOP", allCommands["STOP"] }
        };
        public static Dictionary<string, IGameState> PauseCommands = new Dictionary<string, IGameState>
        {
            {"PLAY", allCommands["PLAY"]},
            {"STOP", allCommands["STOP"] }
        };
        public static Dictionary<string, IGameState> PlayingCommands = new Dictionary<string, IGameState>
        {
            {"CINEMATIC", allCommands["CINEMATIC"]},
            {"PAUSE", allCommands["PAUSE"] },
            {"STOP", allCommands["STOP"] }
        };
        public static Dictionary<string, IGameState> TurnedOffCommands = new Dictionary<string, IGameState>
        {
            {"START", allCommands["START"]}
        };
    }
}
