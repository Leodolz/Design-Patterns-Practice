using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAndObserverPattern
{
    class ChatParticipant : IEventListener
    {
        ChatPublisher publisher;
        private string name;
        public ChatParticipant(ChatPublisher publisher, string name)
        {
            this.publisher = publisher;
            this.name = name;
            this.publisher.AddSubscriber(this,"COMMON");
        }

        public string GetName()
        {
            return name;
        }

        public void update()
        {
            Console.WriteLine("Participant "+GetName()+" recieved: " + publisher.GetChatState());
        }
    }
}
