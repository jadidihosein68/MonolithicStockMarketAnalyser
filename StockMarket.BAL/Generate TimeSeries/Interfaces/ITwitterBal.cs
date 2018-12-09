using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.BAL.Generate_TimeSeries.Interfaces
{
    public interface ITwitterBal
    {
        LinqToTwitterResponces GetTweettsFromTwitter(string ScreenName);
    }
}
