using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Repository.Interface
{
    public interface IRdotNetRepositories
    {
        IEnumerable<MACDIndex> getMACDIndex(IEnumerable<TimeSeriesIndex> input);
        IEnumerable<RSIIndex> getRSIIndex(IEnumerable<TimeSeriesIndex> input);
        IEnumerable<SOIndex> getSOIndex(IEnumerable<TimeSeriesIndex> input);
        IEnumerable<GuppyIndex> getGuppyIndex(IEnumerable<TimeSeriesIndex> input);


        IEnumerable<MACDHistoricalStock> getMACD(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<StochasticOscillatorHistoricalStock> GetStochasticOscillator(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<RSIHistoricalStock> GetRSI(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<GuppyHistoricalStock> GetGuppy(IEnumerable<RowHistoricalStockBase> input);
    }
}
