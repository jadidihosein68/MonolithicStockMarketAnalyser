using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Adapter.Interface
{
    public interface IRdotNetAdapter
    {
        IEnumerable<MACDIndex> CalculateMACDIndex(IEnumerable<TimeSeries> input);
        IEnumerable<RSIIndex> CalculateRSIIndex(IEnumerable<TimeSeries> input);
        IEnumerable<SOIndex> CalculateSOIndex(IEnumerable<TimeSeries> input);
        IEnumerable<GuppyIndex> CalculateGuppyIndex(IEnumerable<TimeSeries> input);

        IEnumerable<MACDHistoricalStock> CalculateMACD(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<StochasticOscillatorHistoricalStock> CalculateStochasticOscillator(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<RSIHistoricalStock> CalculateRSI(IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<GuppyHistoricalStock> CalculateGuppy(IEnumerable<RowHistoricalStockBase> input);
    }
}
