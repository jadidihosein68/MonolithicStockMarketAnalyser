using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.Model;

namespace StockMarket.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwitterController : ControllerBase
    {
        private readonly ITwitterBal TwitterBal; 
        public TwitterController(ITwitterBal _TwitterBal)
        {
            TwitterBal = _TwitterBal;
        }


        [HttpGet("[action]")]
        public LinqToTwitterResponces GetTweetFromTwtter(string ScreenName)
        {
            var result = TwitterBal.GetTweettsFromTwitter(ScreenName);
            return result;
        }


        [HttpGet("[action]")]
        public List<TweetsSummary> GetTweetsSummary()
        {
            List<TweetsSummary> result = new List<TweetsSummary>();
            result.Add(new TweetsSummary {
                LastUpdate = new DateTime(2018,11,1),
                NOofRecords = 3200,
                Screen_Name = "@BarackObama",
            });

            result.Add(new TweetsSummary
            {
                LastUpdate = new DateTime(2018, 11, 1),
                NOofRecords = 6200,
                Screen_Name = "@realDonaldTrump",
            });
            result.Add(new TweetsSummary
            {
                LastUpdate = new DateTime(2018, 11, 1),
                NOofRecords = 6200,
                Screen_Name = "@JZarif",
            });

            return result;
        }



    }
}