using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.BAL.Generate_TimeSeries
{
    public class TwitterBal : ITwitterBal
    {

        private readonly ITwitterRepository TwitterRepository;
        public TwitterBal(ITwitterRepository _TwitterRepository)
        {
            TwitterRepository = _TwitterRepository;
        }

        public LinqToTwitterResponces GetTweettsFromTwitter(string ScreenName)
        {
            return TwitterRepository.GetTweettsFromTwitter(ScreenName);
        }

    }
}
