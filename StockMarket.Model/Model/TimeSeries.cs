using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Model.Model
{
    public class TimeSeries
    {
        public DateTime StartDate {get; set;}
        public DateTime EndDate {get; set;}
        public string StockTable {get; set;}
        public string AnalyseTableName {get; set;}
        public MovingAverage MovingAverage = new MovingAverage();
    }
}
