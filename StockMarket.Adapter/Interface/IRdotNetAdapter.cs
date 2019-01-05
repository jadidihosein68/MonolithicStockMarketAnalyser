using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;

namespace StockMarket.Adapter.Interface {
    public interface IRdotNetAdapter {
        IEnumerable<MACDIndex> CalculateMACDIndex (IEnumerable<TimeSeriesIndex> input);
        IEnumerable<RSIIndex> CalculateRSIIndex (IEnumerable<TimeSeriesIndex> input);
        IEnumerable<SOIndex> CalculateSOIndex (IEnumerable<TimeSeriesIndex> input);
        IEnumerable<GuppyIndex> CalculateGuppyIndex (IEnumerable<TimeSeriesIndex> input);

        IEnumerable<MACDHistoricalStock> CalculateMACD (IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<StochasticOscillatorHistoricalStock> CalculateStochasticOscillator (IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<RSIHistoricalStock> CalculateRSI (IEnumerable<RowHistoricalStockBase> input);
        IEnumerable<GuppyHistoricalStock> CalculateGuppy (IEnumerable<RowHistoricalStockBase> input);
    }
}