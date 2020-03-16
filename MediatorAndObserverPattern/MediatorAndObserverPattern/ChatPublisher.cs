using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorAndObserverPattern
{
    class ChatPublisher
    {
        private Dictionary<string, List<IEventListener>> chatSubscribers = new Dictionary<string, List<IEventListener>>
        {
            {"COMMON", new List<IEventListener>()},
            {"MODERATOR", new List<IEventListener>()}
        };
        private string chatState;
        public string GetChatState()
        {
            return chatState;
        }
        public void SetChatEvent(string newEvent, string subscriberType)
        {
            chatState = newEvent;
            NotifySubscribers(subscriberType);
        }
        public void AddSubscriber(IEventListener chatSubscriber, string subscriberType)
        {
            chatSubscribers[subscriberType].Add(chatSubscriber);
        }
        private void NotifySubscribers(string type)
        {
            foreach(IEventListener subscriber in chatSubscribers[type])
            {
                subscriber.update();
            }
        }
        public void ShowAllChatsubscribers()
        {
            foreach (KeyValuePair<string,List<IEventListener>> subscriber in chatSubscribers)
            {
                foreach(IEventListener eventListener in subscriber.Value)
                {
                    Console.WriteLine(eventListener.GetName());
                }
            }
        }
    }
}
