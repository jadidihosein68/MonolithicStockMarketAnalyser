using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class GuppyHistoricalStock : RowHistoricalStockBase
    {

        public GuppyHistoricalStock()
        :base(){}

        public double shortlag3 { get; set; }
        public double shortlag5 { get; set; }
        public double shortlag8 { get; set; }
        public double shortlag10 { get; set; }
        public double shortlag12 { get; set; }
        public double shortlag15 { get; set; }
        public double longlag30 { get; set; }
        public double longlag35 { get; set; }
        public double longlag40 { get; set; }
        public double longlag45 { get; set; }
        public double longlag50 { get; set; }
        public double longlag60 { get; set; }

    }
}
