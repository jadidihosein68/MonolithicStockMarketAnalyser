using StockMarket.Adapter.Interface;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.Repositories
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
