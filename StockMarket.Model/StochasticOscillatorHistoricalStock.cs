using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Model
{
    public class StochasticOscillatorHistoricalStock : RowHistoricalStockBase
   {
        public StochasticOscillatorHistoricalStock()
        :base(){

        }
        public double fastK { get; set; }
        public double fastD { get; set; }
        public double slowD { get; set; }
    }
}
