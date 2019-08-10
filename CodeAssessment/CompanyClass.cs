using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.SyndicationFeed;

namespace CodeAssessment
{
    class CompanyClass
    {
        public void FindInactiveCompanies(Dictionary<string, string> companyDictionary)
        {
            companyDictionary.ToList().ForEach(x => Console.WriteLine(x.Key));

            foreach (KeyValuePair<string, string> entry in companyDictionary)
            {
                XmlReader reader = XmlReader.Create(entry.Value);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                foreach (SyndicationItem item in feed.Items)
                {
                    string lastUpdated = item.lastBuildDate.Text;
                }

            }

        }
    }
}
