using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    interface NewsFeed
    {
        Dictionary<string,List<string>> GetNewsHeadlines(string topic);
        NewsArticle DownloadNewsArticle(string topic, string headline);
    }
}
