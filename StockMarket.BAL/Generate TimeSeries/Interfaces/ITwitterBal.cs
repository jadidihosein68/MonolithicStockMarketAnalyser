using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model;

namespace StockMarket.BAL.Generate_TimeSeries.Interfaces {
    public interface ITwitterBal {
        LinqToTwitterResponces GetTweettsFromTwitter (string ScreenName);
        IEnumerable<TweetsSummary> GetTweetsSummaries ();
    }
}