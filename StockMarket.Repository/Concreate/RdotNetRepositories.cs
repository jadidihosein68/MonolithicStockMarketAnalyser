using StockMarket.Adapter.Interface;
using StockMarket.Model;
using StockMarket.Model.Base;
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
