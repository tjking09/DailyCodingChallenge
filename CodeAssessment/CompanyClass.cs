using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.SyndicationFeed;
using SyndicationItem = System.ServiceModel.Syndication.SyndicationItem;

namespace CodeAssessment
{
    class CompanyClass
    {
        public void FindInactiveCompanies(Dictionary<string, string> companyDictionary, int daysBack)
        {
            // companyDictionary.ToList().ForEach(x => Console.WriteLine(x.Key));

            daysBack *= -1;
            DateTime checkDate = DateTime.Now.AddDays(daysBack);

            Console.WriteLine($"Check Date: {checkDate}");

            foreach (KeyValuePair<string, string> entry in companyDictionary)
            {
                XmlReader reader = XmlReader.Create(entry.Value);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                Console.WriteLine($"\n{entry.Key}");

                foreach (SyndicationItem item in feed.Items)
                {
                    DateTime lastUpdated = item.PublishDate.Date;
                    if (lastUpdated != null)
                    {
                        Console.WriteLine($"Last Updated: {lastUpdated}");
                        if (lastUpdated > checkDate)
                        {
                            Console.WriteLine("It is up to date");
                        }
                        else
                        {
                            Console.WriteLine("It hasn't been updated lately");
                        }
                        break;
                    }
                }
            }
        }
    }
}
