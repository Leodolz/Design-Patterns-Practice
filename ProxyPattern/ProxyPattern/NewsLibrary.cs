using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public static class NewsLibrary
    {
        private static Dictionary<string, List<NewsArticle>> allNews = new Dictionary<string, List<NewsArticle>>
        {
            { "Climate Change",new List<NewsArticle>
                {
                    new NewsArticle("South Pole Icebergs melting faster","There have been studies that proof that global warming is getting worse due to Greenhouse effect.\nPenguins are starting to migrate to America","Very concered about pollution"),
                    new NewsArticle("Marco Rubio Tries to Debunk Global Warming","Florida's Senator: Marco Rubio has recently declared that global warming is a lie, and he promises to put efforts in order to proof that all this facts are made up","Polititians will be Polititians")
                }
            },
            { "Celebrities", new List<NewsArticle>
                {
                    new NewsArticle("Foreign film steals the show at Oscar's","Foreign film 'Parasite' has won several prizes at the Oscar's event.\nThe biggest prize awarding event was shocked","No more favoritism between local movies"),
                    new NewsArticle("Cristiano Ronaldo in Quarantine","Star soccer player Cristiano Ronaldo has stated that he will not get out of his house until he will be recovered by the new COVID-19","Self-less celebrity gives example")
                }
            },
            { "Travel", new List<NewsArticle>
                {
                    new NewsArticle("Japan declares 'Red Alert' on Tourism","The Asian country declares to be 'Really worried' about the current tourists flow currently in it's most iconic cities\nThe country encourages people to go visit their places now that those are more empty","More space for introverts"),
                    new NewsArticle("Terror Onboard continues","Cruise Ship 'Diamond Princess' is still in quarantine because of the COVID-19 outbreak it had almost two months ago\nPassengers are really scared as the number of infected people continues to grow","Dream retirement travel ruined")
                }
            }
        };
        public static List<NewsArticle> GetNewsFromTopicAPI(string topic)
        {
            List<string> headlines = new List<string>();
            List<NewsArticle> newsArticles = new List<NewsArticle>();
            if (allNews.ContainsKey(topic))
                newsArticles = allNews[topic];
            return newsArticles;
        }
    }
}
