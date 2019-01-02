using StockMarket.Model;
using StockMarket.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Repository.Interface
{
    public interface IRdotNetRepositories
    {
        IEnumerable<MACDHistoricalStock> getMACD(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<StochasticOscillatorHistoricalStock> GetStochasticOscillator(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<RSIHistoricalStock> GetRSI(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<GuppyHistoricalStock> GetGuppy(IEnumerable<RowHistoricalStockBase> input);
    }
}
