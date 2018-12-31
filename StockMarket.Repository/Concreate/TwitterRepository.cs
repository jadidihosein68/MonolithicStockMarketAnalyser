using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Adapter.Interface;
using StockMarket.DAL.Interface.Persistance;
using StockMarket.Model;
using StockMarket.Model.Configuration;
using StockMarket.Repository.Interface;

namespace StockMarket.Repository.Concreate {
    public class TwitterRepository : ITwitterRepository {
        private readonly ITwitterAdapter twitterAdapter;
        private readonly IUnitOfWork IUnitOfWork;

        public TwitterRepository (
            ITwitterAdapter _TwitterAdapter, IUnitOfWork _IUnitOfWork) {
            twitterAdapter = _TwitterAdapter;
            IUnitOfWork = _IUnitOfWork;
        }

        public LinqToTwitterResponces GetAllTweettsFromTwitterByName (string ScreenName) {
            return twitterAdapter.GetTweetsFromTwitter (ScreenName);
        }

        public LinqToTwitterResponces GetTweettsFromTwitterByNameAndDate (TwitterFilter Filter) {
            return twitterAdapter.GetTweettsFromTwitterByNameAndDate (Filter);
        }

        public void SaveTweets (IEnumerable<Tweet> tweets) {
            IUnitOfWork.TwitterDAL.AddRange (tweets);
            IUnitOfWork.Complite ();
        }

        public IEnumerable<TweetsSummary> GetTweetSmmary () {
            return IUnitOfWork.TwitterDAL.GetTweetSmmary ();
        }

        public TweetsSummary GetLatestTweetSummary (string screen) {
            return IUnitOfWork.TwitterDAL.GetLatestTweetSummary (screen);
        }

        public IEnumerable<Tweet> GetTweetsByScreenName (string ScreenName) {
            return IUnitOfWork.TwitterDAL.GetTweetsByScreenName (ScreenName);
        }
    }

}