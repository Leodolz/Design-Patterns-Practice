using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentMaker documentMaker = new DocumentMaker();
            documentMaker.MakeDocument("SIMPLE", "This document is to remind myself to write cleaner code", "Remind", "Try to use design patterns");
            documentMaker.MakeDocument("SIMPLE", "This is a quick document to reminding me to go to an appointment at 5:00 PM");
            documentMaker.MakeDocument("SIMPLE", "This is another quick document to reminding me to go to an appointment at 7:00 PM");
            documentMaker.MakeDocument("SIMPLE", "This is another quick document to reminding me to go to an appointment at 9:00 PM");
            documentMaker.MakeDocument("IMAGES", "This is a documental about monkeys monkey.jpg they have lived several years in this country landscape.jpg " +
                "and have been vinishing from our lands the last years, so this image may not be seen by out grandkids monkey.jpg", "Monkeys: A sad truth",
                "We should do something about it", new Dictionary<string, string>
                {
                    {"monkey.jpg","A monkey standing in a tree"},
                    {"landscape.jpg","A beautiful landscape for monkeys"},
                    {"unused.jpg","An unused image"}
                });
            Console.ReadKey();
        }
    }
}
