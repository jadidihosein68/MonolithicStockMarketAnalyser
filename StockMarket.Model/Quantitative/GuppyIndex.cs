using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Quantitative
{
    public class GuppyIndex
    {
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
        public TimeSeries TimeSeries { get; set; }
        public double Id { get; set; }
        public double TimeSeriesId { get; set; }


    }
}
