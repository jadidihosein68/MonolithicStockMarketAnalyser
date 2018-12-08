using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Adapter.Interface
{
    public interface IRdotNetAdapter
    {
        IEnumerable<MACDHistoricalStock> CalculateMACD(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<StochasticOscillatorHistoricalStock> CalculateStochasticOscillator(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<RSIHistoricalStock> CalculateRSI(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<GuppyHistoricalStock> CalculateGuppy(IEnumerable<RowHistoricalStockBase> input);
    }
}
