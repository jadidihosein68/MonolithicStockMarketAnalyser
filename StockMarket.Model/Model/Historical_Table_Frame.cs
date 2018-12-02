using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model.Model
{
    public class Historical_Table_Frame
    {
        public string Symbol { get; set; }
        public string TableName { get; set; }
        public DateTime LastUpdate { get; set; }

    }
}
