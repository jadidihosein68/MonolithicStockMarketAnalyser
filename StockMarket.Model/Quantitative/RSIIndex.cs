using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Quantitative
{
    public class RSIIndex
    {
        public DateTime Date { get; set; }
        public double RSI { get; set; }
        public TimeSeries TimeSeries { get; set; }
        public double Id { get; set; }
        public double TimeSeriesId { get; set; }


    }
}
