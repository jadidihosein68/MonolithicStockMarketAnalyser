using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.Model;
using StockMarket.Repository.Interface;

namespace StockMarket.BAL.ExtractText {
    public class TwitterBal : ITwitterBal {

        private readonly ITwitterRepository TwitterRepository;
        public TwitterBal (ITwitterRepository _TwitterRepository) {
            TwitterRepository = _TwitterRepository;
        }

        public LinqToTwitterResponces GetTweettsFromTwitter (string ScreenName) {
            var latest = TwitterRepository.GetLatestTweetSummary (ScreenName);

            var result = latest == null ?
                TwitterRepository.GetAllTweettsFromTwitterByName (ScreenName) :
                TwitterRepository.GetTweettsFromTwitterByNameAndDate (new Model.Configuration.TwitterFilter { LatestTweets = latest.LastTweetDate, screenName = ScreenName });

            TwitterRepository.SaveTweets (result.Tweets);
            return result;
        }

        public IEnumerable<TweetsSummary> GetTweetsSummaries () {
            return TwitterRepository.GetTweetSmmary ();
        }

        public IEnumerable<Tweet> GetTweetsByScreenName (string ScreenName) {
            return TwitterRepository.GetTweetsByScreenName (ScreenName);
        }

    }
}