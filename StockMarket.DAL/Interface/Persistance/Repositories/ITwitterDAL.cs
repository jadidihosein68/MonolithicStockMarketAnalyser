using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model;

namespace StockMarket.DAL.Interface.Persistance.Repositories {
    public interface ITwitterDAL {
        void AddRange (IEnumerable<Tweet> DataSet);
        IEnumerable<TweetsSummary> GetTweetSmmary ();
        TweetsSummary GetLatestTweetSummary (string screen);
        IEnumerable<Tweet> GetTweetsByScreenName (string ScreenName);

    }
}