using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class StockFocuse
    {
        public string FocseName { get; set; }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Index { get; set; }
        public ICollection<StockLabel> StockLabels { get; set; }


    }
}
