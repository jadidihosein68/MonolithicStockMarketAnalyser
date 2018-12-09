using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class Tweet
    {
        public ulong TweetID { get; set;}
        public string Screen_Name { get; set; }
        public DateTime Date { get; set; }
        public string Tweets { get; set; }
    }
}
