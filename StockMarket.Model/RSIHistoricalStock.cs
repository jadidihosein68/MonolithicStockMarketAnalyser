using StockMarket.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class RSIHistoricalStock : RowHistoricalStockBase
    {
        public RSIHistoricalStock()
        :base(){

        }

        public double RSI { get; set; }

    }
}
