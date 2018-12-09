using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class LinqToTwitterResponces
    {
        public List<Tweet> Tweets { get; set; }
        public string ScreenName { get; set; }
        public int TotalNoOfTweets { get; set; }
    }
}
