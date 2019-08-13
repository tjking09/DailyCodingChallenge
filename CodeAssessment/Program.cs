using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysBack = 2;

            var instance = new CompanyClass();

            Dictionary<string, string> CompanyDictionary = new Dictionary<string, string>
            {
                { "ESPN", "https://www.espn.com/espn/rss/news" },
                { "Bill Simmons Podcast", "https://rss.art19.com/the-bill-simmons-podcast" },
                { "Hacker News", "https://hnrss.org/newest" }
            };

            instance.FindInactiveCompanies(CompanyDictionary, daysBack);

            Console.ReadLine();
        }
    }
}
