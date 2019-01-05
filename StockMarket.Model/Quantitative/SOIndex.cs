using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Quantitative
{
    public class SOIndex
    {
        public double fastK { get; set; }
        public double fastD { get; set; }
        public double slowD { get; set; }
        public TimeSeries TimeSeries { get; set; }
        public double Id { get; set; }
        public double TimeSeriesId { get; set; }


    }
}
