using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;

namespace StockMarket.DAL.Persistence.Repositories {
    public class TwitterDAL : ITwitterDAL {

        private readonly ISalDbContext context;
        public TwitterDAL (ISalDbContext _context) {
            context = _context;
        }

        public void AddRange (IEnumerable<Tweet> DataSet) {
            context.Tweet.AddRange (DataSet);
        }

        public IEnumerable<TweetsSummary> GetTweetSmmary () {
            return context.TweetsSummary.ToList ();
        }

        public TweetsSummary GetLatestTweetSummary (string screen) {
            var maxDate = context.TweetsSummary.Where (c => c.Screen_Name == screen).DefaultIfEmpty ().Max (c => c.LastTweetDate);
            return context.TweetsSummary.FirstOrDefault (c => c.Screen_Name == screen && c.LastTweetDate == maxDate);
        }

        public IEnumerable<Tweet> GetTweetsByScreenName (string ScreenName) {
            return context.Tweet.Where (c => c.Screen_Name == ScreenName).ToList ();

        }

    }
}