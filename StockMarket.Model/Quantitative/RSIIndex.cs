using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Quantitative
{
    public class RSIIndex
    {
        public DateTime Date { get; set; }
        public double RSI { get; set; }
        public TimeSeriesIndex TimeSeries { get; set; }
        public int RSIId { get; set; }
        public int TimeSeriesId { get; set; }


    }
}
