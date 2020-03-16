using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAndObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator broadcastServer = new ChatMediator();
            broadcastServer.AddParticipant("Juan");
            broadcastServer.AddParticipant("Miguel");
            broadcastServer.AddParticipant("Joaquin");
            broadcastServer.AddModerator("Joel");
            broadcastServer.AddModerator("Elizabeth");
            broadcastServer.SendCommonMessage("Hello common members!");
            broadcastServer.SendModeratorMessage("Hello moderator partners!");
            broadcastServer.SendTo("Hi Miguel!", "Miguel", "COMMON");
            Console.ReadKey();
        }
    }
}
