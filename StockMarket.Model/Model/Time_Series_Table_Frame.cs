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
            public decimal? Adj_Close { get; set; }
            public decimal? _12_Days_Ema { get; set; }
            public decimal? _26_Days_Ema { get; set; }
            public decimal? MACD_12Minus26_days { get; set; }
            public decimal? _Signal { get; set; }
            public decimal? _histogram { get; set; }
            public decimal? Change { get; set; }
            public decimal? gain { get; set; }
            public decimal? Loss { get; set; }
            public decimal? Avg_Gain { get; set; }
            public decimal? Avg_Loss { get; set; }
            public decimal? RS { get; set; }
            public decimal? _14_days_RSI { get; set; }
            public decimal? highest_high_14 { get; set; }
            public decimal? Lowest_low_14 { get; set; }
            public decimal? _14_day_StochasticOscillator { get; set; }
            public decimal? _3_days_Ema { get; set; }
            public decimal? _5_days_Ema { get; set; }
            public decimal? _8_days_Ema { get; set; }
            public decimal? _10_days_Ema { get; set; }
            public decimal? _15_days_Ema { get; set; }
            public decimal? _30_days_Ema { get; set; }
            public decimal? _35_days_Ema { get; set; }
            public decimal? _40_days_Ema { get; set; }
            public decimal? _45_days_Ema { get; set; }
            public decimal? _50_days_Ema { get; set; }
            public decimal? _60_days_Ema { get; set; }
        }
    }

