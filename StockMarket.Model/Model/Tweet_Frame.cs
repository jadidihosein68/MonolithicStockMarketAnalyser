using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Model
{
    public class Tweet_Frame
    {
        public ulong TweetID { get; set; }
        public string ScreenName { get; set; }
        public DateTime Date { get; set; }
        public string Tweets { get; set; }
        public string TweetFrames_ToString()
        {
            return ScreenName + "," + TweetID + "," + Date.ToString("yyyy-MM-dd") + "," + Tweets;
        }
    }
}
