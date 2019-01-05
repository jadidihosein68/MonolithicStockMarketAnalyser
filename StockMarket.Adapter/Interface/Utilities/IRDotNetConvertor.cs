using System;
using System.Collections.Generic;
using System.Text;
using RDotNet;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;

namespace StockMarket.Adapter.Interface.Utilities {
    public interface IRDotNetConvertor {
        DataFrame StockBaseToDataFrame (IEnumerable<RowHistoricalStockBase> input, REngine engine);
        DataFrame TimeSeriesToDataFrame (IEnumerable<TimeSeriesIndex> input, REngine engine);
        IEnumerable<MACDIndex> DataFrametoMACDIndexMapper (DataFrame dataframe);
        IEnumerable<SOIndex> DataFrametoSOIndexMapper (DataFrame dataframe);
        IEnumerable<RSIIndex> DataFrametoRSIIndexMapper (DataFrame dataframe);
        IEnumerable<GuppyIndex> DataFrametoGuppyIndexMapper (DataFrame dataframe);

        IEnumerable<MACDHistoricalStock> DataFrametoMACDMapper (DataFrame dataframe);
        IEnumerable<StochasticOscillatorHistoricalStock> DataFrametoStochasticOscillatorMapper (DataFrame dataframe);
        IEnumerable<RSIHistoricalStock> DataFrametoRSIMapper (DataFrame dataframe);
        IEnumerable<GuppyHistoricalStock> DataFrametoGuppyMapper (DataFrame dataframe);
    }
}