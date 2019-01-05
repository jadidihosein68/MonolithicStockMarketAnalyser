using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Quantitative
{
    public class MACDIndex
    {
        public double MACD { get; set; }
        public double Signal { get; set; }
        public double Histogram { get { return MACD - Signal; } set { } }
        public TimeSeries TimeSeries { get; set; }
        public double Id { get; set; }
        public double TimeSeriesId { get; set; }
    }
}
