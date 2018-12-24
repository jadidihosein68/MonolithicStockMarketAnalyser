using LinqToTwitter;
using Microsoft.Extensions.Options;
using StockMarket.Adapter.Interface;
using StockMarket.Model.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using StockMarket.Model;

namespace StockMarket.Adapter
{
    public class TwitterAdapter : ITwitterAdapter
    {
        private readonly AppConfiguration AppConfiguration;

        public TwitterAdapter(IOptions<AppConfiguration> _AppConfiguration)
        {
            AppConfiguration = _AppConfiguration.Value;
        }

        public LinqToTwitterResponces GetTweetsFromTwitter(string ScreenName)
        {

            if (string.IsNullOrEmpty(ScreenName))
                return null;

            var authorizer = CreateAuthorizer();
            var twitterContext = new TwitterContext(authorizer);

            var statusTweets = twitterContext.Status.Where(
                c => c.Type == StatusType.User
                && c.ScreenName == ScreenName
                && c.IncludeContributorDetails == true
                && c.Count == 200
                && c.IncludeEntities == true);
            List<Tweet> mystorage = SendRequestToGetTweets(statusTweets, twitterContext, ScreenName);
            LinqToTwitterResponces response = new LinqToTwitterResponces()
            {
                ScreenName = ScreenName,
                TotalNoOfTweets = mystorage.Count,
                Tweets = mystorage
            };
            return response;

        }


        private SingleUserAuthorizer CreateAuthorizer()
        {

            return new SingleUserAuthorizer
            {
                CredentialStore = new InMemoryCredentialStore
                {
                    ConsumerKey = AppConfiguration.TwitterCrodential.consumerKey,
                    ConsumerSecret = AppConfiguration.TwitterCrodential.consumerSecret,
                    OAuthToken = AppConfiguration.TwitterCrodential.accessToken,
                    OAuthTokenSecret = AppConfiguration.TwitterCrodential.accessTokenSecret
                }
            };

        }


        private List<Tweet> SendRequestToGetTweets(IQueryable<Status> statusTweets, TwitterContext twitterContext, string ScreenName)
        {

            ulong temp = 0;
            int i = 0;
            List<Tweet> mystorage = new List<Tweet>();

            foreach (var statusTweet in statusTweets)
            {
                i++;
                DateTime dt = Convert.ToDateTime(statusTweet.CreatedAt);
                mystorage.Add(new Tweet()
                {
                    Date = dt,
                    Screen_Name = statusTweet.ScreenName.ToString(),
                    TweetID = statusTweet.StatusID,
                    Tweets = statusTweet.Text.ToString()
                });

                if (i == 200)
                {
                    temp = statusTweet.StatusID;
                }
            }


            while (i != 0)
            {

                var statusTweets2 =
                     twitterContext.Status.Where(
                c => c.Type == StatusType.User
                && c.ScreenName == ScreenName
                && c.IncludeContributorDetails == true
                && c.Count == 200
                && c.IncludeEntities == true
                && c.MaxID == temp - 1
                );

                i = 0;
                foreach (var statusTweet in statusTweets2)
                {
                    i++;
                    DateTime dt = Convert.ToDateTime(statusTweet.CreatedAt);
                    mystorage.Add(new Tweet()
                    {
                        Date = dt,
                        Screen_Name = statusTweet.ScreenName.ToString(),
                        TweetID = statusTweet.StatusID,
                        Tweets = statusTweet.Text.ToString()
                    });
                }
                temp = mystorage[mystorage.Count - 1].TweetID;
            }

            return mystorage;
        }

    }

}
