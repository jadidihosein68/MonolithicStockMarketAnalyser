using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class MACDHistoricalStock : RowHistoricalStockBase
    {
        public MACDHistoricalStock() :base()
        {

        }
        public double MACD { get; set; }
        public double Signal { get; set; }
        public double Histogram { get { return MACD - Signal; } set{} }
    }
}
