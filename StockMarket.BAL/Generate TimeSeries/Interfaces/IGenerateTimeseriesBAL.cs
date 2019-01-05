using StockMarket.Model;
using StockMarket.Model.Quantitative;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.BAL.Generate_TimeSeries.Interfaces
{
    public interface IGenerateTimeseriesBAL
    {
        IEnumerable<MACDIndex> generateMACDIndex(string StockIndex);
        IEnumerable<SOIndex> generateSOIndex(string StockIndex);
        IEnumerable<RSIIndex> generateRSIIndex(string StockIndex);
        IEnumerable<GuppyIndex> generateGuppyIndex(string StockIndex);



        IEnumerable<MACDHistoricalStock> generateMacd(string StockIndex);
        IEnumerable<StochasticOscillatorHistoricalStock> generateStochasticOscillator(string StockIndex);
        IEnumerable<RSIHistoricalStock> generateRSI(string StockIndex);
        IEnumerable<GuppyHistoricalStock> generateGuppy(string StockIndex);
        bool SyncTimeSeries(string StockIndex);

    }
}
