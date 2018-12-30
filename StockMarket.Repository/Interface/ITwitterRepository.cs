using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Repository.Interface
{
    public interface ITwitterRepository
    {
        LinqToTwitterResponces GetTweettsFromTwitter(string ScreenName);
    }
}
