using StockMarket.Adapter.Interface;
using StockMarket.Model;
using StockMarket.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Repository.Concreate
{
    public class TwitterRepository : ITwitterRepository
    {
        private readonly ITwitterAdapter TwitterAdapter;
        public TwitterRepository(ITwitterAdapter _TwitterAdapter)
        {
            TwitterAdapter = _TwitterAdapter;
        }

        public LinqToTwitterResponces GetTweettsFromTwitter(string ScreenName)
        {
            return TwitterAdapter.GetTweetsFromTwitter(ScreenName);
        }

    }
}
