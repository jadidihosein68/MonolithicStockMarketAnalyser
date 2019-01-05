using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class StockFocuse
    {
        public int Id { get; set; }
        public string FocseName { get; set; }
        public string StockIndex { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
