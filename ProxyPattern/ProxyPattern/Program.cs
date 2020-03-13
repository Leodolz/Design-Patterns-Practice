using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsFeed clientNewsFeed = new NewsFeedProxy(new NewsFeedMainPage());
            DescribeHeadlines(clientNewsFeed.GetNewsHeadlines("Climate Change"), "Climate Change");
            DescribeHeadlines(clientNewsFeed.GetNewsHeadlines("Celebrities"), "Celebrities");
            DescribeHeadlines(clientNewsFeed.GetNewsHeadlines("Travel"), "Travel");
            clientNewsFeed.DownloadNewsArticle("Travel", "Terror").readNews();
            DescribeHeadlines(clientNewsFeed.GetNewsHeadlines("Climate Change"), "Climate Change");
            clientNewsFeed.DownloadNewsArticle("Travel", "Terror").readNews();
            clientNewsFeed.DownloadNewsArticle("Climate Change", "South").readNews();
            Console.ReadKey();
        }
        static void DescribeHeadlines(Dictionary<string,List<string>> headlinesGroup, string topic)
        {
            Console.WriteLine("Describing Headlines of "+topic);
            foreach(string newsHeadline in headlinesGroup[topic])
            {
                Console.WriteLine("* " + newsHeadline);
            }
            Console.WriteLine("");
        }
    }
}
