using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Base
{
    public class RowHistoricalStockBase // order is important !
    {

        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal Volume { get; set; }
        public int Id { get; set; }
        public string StockIndex { get; set; }
    }
}
