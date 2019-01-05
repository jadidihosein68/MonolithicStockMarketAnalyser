using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class TimeSeries : BaseClass
    {
        public double Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal Volume { get; set; }
        public string StockIndex { get; set; }
        public virtual MACDIndex MACDIndex { get;set;}
        public virtual RSIIndex RSIIndex { get;set;}
        public virtual GuppyIndex GuppyIndex { get;set;}
        public virtual SOIndex SOIndex { get;set;}

    }
}
