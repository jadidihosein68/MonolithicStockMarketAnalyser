using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Model
{
    public class Tweet_Frame
    {
        public ulong TweetID { get; set; }
        public string Screen_Name { get; set; }
        public DateTime Date { get; set; }
        private string Tweets { get; set; }
        public string TweetFrames_ToString()
        {
            return Screen_Name + "," + TweetID + "," + Date.ToString("yyyy-MM-dd") + "," + Tweets;
        }
    }
}
