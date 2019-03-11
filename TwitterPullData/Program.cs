using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace TwitterPullData
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new Twitter
            {
                OAuthConsumerKey = "XXX",
                OAuthConsumerSecret = "XXXX"
            };
            IEnumerable<string> tweets = twitter.GetTweets("user name", 10).Result;
            foreach (var t in tweets)
            {
                Console.WriteLine(t+"\n");
            }
            Console.ReadKey();

        }
    }
}
