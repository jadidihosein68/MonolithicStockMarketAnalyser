using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model;
using StockMarket.Model.Configuration;

namespace StockMarket.Adapter.Interface {
    public interface ITwitterAdapter {
        LinqToTwitterResponces GetTweetsFromTwitter (string ScreenName);
        LinqToTwitterResponces GetTweettsFromTwitterByNameAndDate (TwitterFilter Filter);

    }
}