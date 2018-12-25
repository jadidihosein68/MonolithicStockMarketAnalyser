using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Configuration
{
    public class AppConfiguration
    {
        public string QuandlAPIKey { get; set; }
        public Endpoints Endpoints { get; set; }
        public TwitterCrodential TwitterCrodential { get; set; }
        public string ConnectionString { get; set;}
    }
}
