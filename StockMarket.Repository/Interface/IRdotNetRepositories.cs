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
        IEnumerable<MACDIndex> getMACDIndex(IEnumerable<TimeSeries> input);
        IEnumerable<RSIIndex> getRSIIndex(IEnumerable<TimeSeries> input);
        IEnumerable<SOIndex> getSOIndex(IEnumerable<TimeSeries> input);
        IEnumerable<GuppyIndex> getGuppyIndex(IEnumerable<TimeSeries> input);


        IEnumerable<MACDHistoricalStock> getMACD(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<StochasticOscillatorHistoricalStock> GetStochasticOscillator(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<RSIHistoricalStock> GetRSI(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<GuppyHistoricalStock> GetGuppy(IEnumerable<RowHistoricalStockBase> input);
    }
}
