using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class NewsFeedProxy : NewsFeed
    {
        private List<Dictionary<string, List<string>>> newsHeadlinesCache;
        private List<NewsArticle> newsArticlesCache;
        private NewsFeedMainPage mainPageService;
        public NewsFeedProxy(NewsFeedMainPage mainPageService)
        {
            newsHeadlinesCache = new List<Dictionary<string, List<string>>>();
            newsArticlesCache = new List<NewsArticle>();
            this.mainPageService = mainPageService;
        }
        public NewsArticle DownloadNewsArticle(string topic, string headline)
        {
            NewsArticle cachedArticle = newsArticlesCache.Find(newsArticle => newsArticle.headlines.StartsWith(headline));
            if (cachedArticle == null)
            {
                NewsArticle downloadedArticle = mainPageService.DownloadNewsArticle(topic, headline);
                newsArticlesCache.Add(downloadedArticle);
                return downloadedArticle;
            }
            Console.WriteLine("Retrieving news article from cache");
            return cachedArticle;
        }

        public Dictionary<string, List<string>> GetNewsHeadlines(string topic)
        {
            Dictionary<string, List<string>> cachedNewsHeadlines = newsHeadlinesCache.Find(headlinesDictionary => headlinesDictionary.ContainsKey(topic));
            if (cachedNewsHeadlines == null)
            {
                Dictionary<string, List<string>> downloadedHeadlines = mainPageService.GetNewsHeadlines(topic);
                newsHeadlinesCache.Add(downloadedHeadlines);
                return downloadedHeadlines;
            }
            Console.WriteLine("Retrieving news headlines from cache");
            return cachedNewsHeadlines;
        }
    }
}
