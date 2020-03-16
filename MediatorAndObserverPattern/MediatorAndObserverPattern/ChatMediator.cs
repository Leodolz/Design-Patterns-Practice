using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAndObserverPattern
{
    class ChatMediator
    {
        private ChatPublisher officialPublisher = new ChatPublisher();
        private static string commonCode = "COMMON";
        private static string moderatorCode = "MODERATOR";
        public void AddParticipant(string name)
        {
            officialPublisher.SetChatEvent(name + " joined the chat!", commonCode);
            new ChatParticipant(officialPublisher,name);
        }
        public void AddModerator(string name)
        {
            new ChatModerator(officialPublisher,name);
            officialPublisher.SetChatEvent(name+" moderator has joined the chat!", moderatorCode);
        }
        public void SendCommonMessage(string message)
        {
            officialPublisher.SetChatEvent(message, commonCode);
        }
        public void SendModeratorMessage(string message)
        {
            officialPublisher.SetChatEvent(message, moderatorCode);
        }
    }
}
