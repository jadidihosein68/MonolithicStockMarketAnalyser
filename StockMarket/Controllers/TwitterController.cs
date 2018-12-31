using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.Model;

namespace StockMarket.Core.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase {
        private readonly ITwitterBal TwitterBal;
        public TwitterController (ITwitterBal _TwitterBal) {
            TwitterBal = _TwitterBal;
        }

        [HttpGet ("[action]")]
        public LinqToTwitterResponces GetTweetFromTwtter (string ScreenName) {
            var result = TwitterBal.GetTweettsFromTwitter (ScreenName);
            return result;
        }

        [HttpGet ("[action]")]
        public IEnumerable<TweetsSummary> GetTweetsSummary () {
            return TwitterBal.GetTweetsSummaries ();
        }

    }
}