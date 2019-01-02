using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class StockLabel
    {
        public int StockLabelId { get; set; }
        public int StockFocuseID { get; set; }
        public DateTime Date { get; set; }
        public string Label { get; set; }
        public StockFocuse StockFocuse { get; set; }

    }
}
