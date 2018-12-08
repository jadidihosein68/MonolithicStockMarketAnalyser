using StockMarket.Adapter.Interface;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.Repositories
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

    }
}
