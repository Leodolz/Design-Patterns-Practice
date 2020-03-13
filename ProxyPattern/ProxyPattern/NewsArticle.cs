using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class NewsArticle
    {
        public string headlines { get; set; }
        public string newsBody { get; set; }
        public string comments { get; set; }
        public NewsArticle(string headlines, string newsBody, string comments)
        {
            this.headlines = headlines;
            this.newsBody = newsBody;
            this.comments = comments;
        }
        public void readNews()
        {
            Console.WriteLine(headlines.ToUpper() + "\n" + newsBody + "\nComments: " + comments+"\n");
        }
    }
}
