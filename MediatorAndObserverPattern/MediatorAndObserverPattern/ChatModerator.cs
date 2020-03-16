using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAndObserverPattern
{
    class ChatModerator : IEventListener
    {
        public string name;
        ChatPublisher publisher;
        public ChatModerator(ChatPublisher publisher, string name)
        {
            this.publisher = publisher;
            this.name = name;
            this.publisher.AddSubscriber(this,"MODERATOR");
        }

        public string GetName()
        {
            return name;
        }

        public void update()
        {
            Console.WriteLine("Moderator "+GetName()+" received: "+publisher.GetChatState());
        }
    }
}
