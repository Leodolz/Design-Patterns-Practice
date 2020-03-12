using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameOriginator gameOriginator = new GameOriginator(new GameState(0, "Silp", DateTime.Now));
            GameCaretaker caretaker = new GameCaretaker();
            continueWithKey();
            caretaker.MakeBackup(gameOriginator.Save());
            gameOriginator.NextLevel();
            continueWithKey();
            caretaker.MakeBackup(gameOriginator.Save());
            gameOriginator.NextLevel();
            gameOriginator.NextLevel();
            gameOriginator.NextLevel();
            gameOriginator.DescribeCurrentLevel();
            caretaker.ShowHistory();
            Console.WriteLine("Making undo");
            continueWithKey();
            caretaker.Undo(gameOriginator);
            Console.WriteLine("Making another undo");
            continueWithKey();
            caretaker.Undo(gameOriginator);
            caretaker.ShowHistory();
            continueWithKey();
        }
        static void continueWithKey()
        {
            Console.WriteLine("Press Any key to continue");
            Console.ReadKey();
        }
    }
}
