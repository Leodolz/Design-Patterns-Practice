using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class GameCaretaker
    {
        private List<IMemento> mementos = new List<IMemento>();
        public void MakeBackup(IMemento memento)
        {
            Console.WriteLine("-------------Saving state--------------------");
            memento.getGameState().DescribeGame();
            Console.WriteLine("---------------------------------------------");
            mementos.Add(memento);
        }
        public void Undo(GameOriginator gameOriginator)
        {
            IMemento lastMemento = mementos.Last();
            mementos.Remove(lastMemento);
            gameOriginator.RestoreGame(lastMemento);
        }
        public void ShowHistory()
        {
            Console.WriteLine("All game's save points: ");
            Console.WriteLine("________________________________");
            foreach(IMemento memento in mementos)
            {
                memento.getGameState().DescribeGame();
                Console.WriteLine("");
            }
            Console.WriteLine("________________________________");
        }
    }
}
