using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class GameState
    {
        public int level { get;}
        public string userName { get; }
        public DateTime timeOfGame { get; }
        public GameState(int level, string userName, DateTime timeOfGame)
        {
            this.level = level;
            this.userName = userName;
            this.timeOfGame = timeOfGame;
        }
        public void DescribeGame()
        {
            Console.WriteLine("User name: "+userName
                +"\nLast played: "+timeOfGame
                +"\nLevel: "+level);
        }
    }
}
