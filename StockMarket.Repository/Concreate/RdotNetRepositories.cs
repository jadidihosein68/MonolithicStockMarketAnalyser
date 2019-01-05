using StockMarket.Adapter.Interface;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;
using StockMarket.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Repository.Concreate
{
    public class RdotNetRepositories : IRdotNetRepositories
    {
        private readonly IRdotNetAdapter RdotNetAdapter;
        public RdotNetRepositories(IRdotNetAdapter _RdotNetAdapter)
        {
            RdotNetAdapter = _RdotNetAdapter;
        }


        public IEnumerable<MACDIndex> getMACDIndex(IEnumerable<TimeSeriesIndex> input)
        {
            var result = RdotNetAdapter.CalculateMACDIndex(input);
            return result;
        }

        public IEnumerable<RSIIndex> getRSIIndex(IEnumerable<TimeSeriesIndex> input)
        {
            var result = RdotNetAdapter.CalculateRSIIndex(input);
            return result;
        }

        public IEnumerable<SOIndex> getSOIndex(IEnumerable<TimeSeriesIndex> input)
        {
            var result = RdotNetAdapter.CalculateSOIndex(input);
            return result;
        }

        public IEnumerable<GuppyIndex> getGuppyIndex(IEnumerable<TimeSeriesIndex> input)
        {
            var result = RdotNetAdapter.CalculateGuppyIndex(input);
            return result;
        }

        public IEnumerable<MACDHistoricalStock> getMACD(IEnumerable<RowHistoricalStockBase> input) {
            var result = RdotNetAdapter.CalculateMACD(input);
            return result;
        }

        public IEnumerable<StochasticOscillatorHistoricalStock> GetStochasticOscillator(IEnumerable<RowHistoricalStockBase> input)
        {
            var result = RdotNetAdapter.CalculateStochasticOscillator(input);
            return result;
        }

        public IEnumerable<RSIHistoricalStock> GetRSI(IEnumerable<RowHistoricalStockBase> input)
        {
            var result = RdotNetAdapter.CalculateRSI(input);
            return result;
        }

        public IEnumerable<GuppyHistoricalStock> GetGuppy(IEnumerable<RowHistoricalStockBase> input)
        {
            var result = RdotNetAdapter.CalculateGuppy(input);
            return result;
        }

    }
}
