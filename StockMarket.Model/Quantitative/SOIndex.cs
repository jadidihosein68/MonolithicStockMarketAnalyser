using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Quantitative
{
    public class SOIndex
    {
        public DateTime Date { get; set; }
        public double fastK { get; set; }
        public double fastD { get; set; }
        public double slowD { get; set; }
        public TimeSeriesIndex TimeSeries { get; set; }
        public int SOId { get; set; }
        public int TimeSeriesId { get; set; }


    }
}
