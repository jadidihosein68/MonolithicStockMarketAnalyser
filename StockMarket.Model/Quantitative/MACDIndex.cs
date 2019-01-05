using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Quantitative
{
    public class MACDIndex
    {
        public DateTime Date { get; set; }
        public double MACD { get; set; }
        public double Signal { get; set; }
        public double Histogram { get { return MACD - Signal; } set { } }
        public TimeSeriesIndex TimeSeries { get; set; }
        public int MACDId { get; set; }
        public int TimeSeriesId { get; set; }
    }
}
