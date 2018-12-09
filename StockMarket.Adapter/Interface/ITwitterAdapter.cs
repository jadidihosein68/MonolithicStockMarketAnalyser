using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Adapter.Interface
{
    public interface ITwitterAdapter
    {
        LinqToTwitterResponces GetTweetsFromTwitter(string ScreenName);
    }
}
