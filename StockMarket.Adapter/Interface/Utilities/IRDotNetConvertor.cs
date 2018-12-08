using RDotNet;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Adapter.Interface.Utilities
{
    public interface IRDotNetConvertor
    {
        DataFrame StockBaseToDataFrame(IEnumerable<RowHistoricalStockBase> input, REngine engine);
        IEnumerable<MACDHistoricalStock> DataFrametoMACDMapper(DataFrame dataframe);
        IEnumerable<StochasticOscillatorHistoricalStock> DataFrametoStochasticOscillatorMapper(DataFrame dataframe);
        IEnumerable<RSIHistoricalStock> DataFrametoRSIMapper(DataFrame dataframe);
        IEnumerable<GuppyHistoricalStock> DataFrametoGuppyMapper(DataFrame dataframe);
    }
}
