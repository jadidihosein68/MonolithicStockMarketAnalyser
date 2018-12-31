using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model;
using StockMarket.Model.Configuration;

namespace StockMarket.Repository.Interface {
    public interface ITwitterRepository {
        LinqToTwitterResponces GetAllTweettsFromTwitterByName (string ScreenName);
        LinqToTwitterResponces GetTweettsFromTwitterByNameAndDate (TwitterFilter Filter);
        void SaveTweets (IEnumerable<Tweet> tweets);
        IEnumerable<TweetsSummary> GetTweetSmmary ();
        TweetsSummary GetLatestTweetSummary (string screen);

    }
}