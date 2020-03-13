using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class NewsFeedMainPage : NewsFeed
    {
        private List<NewsArticle> relatedNews;
        public NewsArticle DownloadNewsArticle(string topic, string newsHeadline)
        {
            Console.WriteLine("Downloading news article...");
            relatedNews = GetNews(topic);
            return relatedNews.Find(newsArticle=> newsArticle.headlines.StartsWith(newsHeadline));
        }
        public Dictionary<string,List<string>> GetNewsHeadlines(string topic)
        {
            Console.WriteLine("Downloading news headlines...");
            relatedNews = GetNews(topic);
            List<string> newsHeadlines = new List<string>();
            foreach(NewsArticle newsArticle in relatedNews)
            {
                newsHeadlines.Add(newsArticle.headlines);
            }
            Dictionary<string, List<string>> topicResult = new Dictionary<string, List<string>> { {topic, newsHeadlines }};
            return topicResult;
        }
        private List<NewsArticle> GetNews(string topic)
        {
            return NewsLibrary.GetNewsFromTopicAPI(topic);
        }
    }
}
