using System;
using System.Collections.Generic;
using System.Text;


namespace StockMarket.Models.Model
{
    public class Time_Series_Table_Frame
    {
        public DateTime Date { get; set; }
        public decimal? Open { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Close { get; set; }
        public decimal? Volume { get; set; }
        public decimal? AdjClose { get; set; }
        public decimal? MACD12Minus26Days { get; set; }
        public decimal? Signal { get; set; }
        public decimal? Histogram { get; set; }
        public decimal? Change { get; set; }
        public decimal? Gain { get; set; }
        public decimal? Loss { get; set; }
        public decimal? AverageGain { get; set; }
        public decimal? AverageLoss { get; set; }
        public decimal? RS { get; set; }
        public decimal? RSI14days { get; set; }
        public decimal? HighestHigh14 { get; set; }
        public decimal? LowestLow14 { get; set; }
        public decimal? StochasticOscillator14Day { get; set; }
        public decimal? Ema3Days { get; set; }
        public decimal? Ema5Days { get; set; }
        public decimal? Ema8Days { get; set; }
        public decimal? Ema10Days { get; set; }
        public decimal? Ema12Days { get; set; }
        public decimal? Ema15Days { get; set; }
        public decimal? Ema26Days { get; set; }
        public decimal? Ema30Days { get; set; }
        public decimal? Ema35Days { get; set; }
        public decimal? Ema40Days { get; set; }
        public decimal? Ema45Days { get; set; }
        public decimal? Ema50Days { get; set; }
        public decimal? Ema60Days { get; set; }
    }
}

