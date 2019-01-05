using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class TweetsSummary
    {
        public DateTime LastTweetDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Screen_Name { get; set; }
        public int NOofRecords { get; set; }
    }
}