using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    class Tweets
    {
        public static List<Models.Tweet> GetTweets()
        {
            return new List<Models.Tweet>();
        }

        public static Models.Tweet CreateTweet(Models.Tweet tweet)
        {
            return new Models.Tweet();
        }
    }
}
