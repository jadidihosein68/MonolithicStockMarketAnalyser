using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
        public class RequestHistoricalStockQuandl
    {
        public string Index { get; set; } = "FB";
        public string DataType { get; set; } = "csv";
    }
}
