using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Configuration {
    public class TwitterFilter {
        public string screenName { get; set; }
        public DateTime LatestTweets { get; set; }
    }
}