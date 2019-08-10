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
            var instance = new CompanyClass();

            Dictionary<string, string> CompanyDictionary = new Dictionary<string, string>();

            CompanyDictionary.Add("ESPN", "https://www.espn.com/espn/rss/news");

            instance.FindInactiveCompanies(CompanyDictionary);

            Console.ReadLine();
        }
    }
}
