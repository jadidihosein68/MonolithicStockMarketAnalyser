
using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket.BAL.Generate_TimeSeries
{
    public class GenerateTimeseriesBAL : IGenerateTimeseriesBAL
    {
        private readonly IRdotNetRepositories RdotNetRepositories;
        private readonly IQuamdlHisoricalStockRepository QuamdlHisoricalStockRepository;

        public GenerateTimeseriesBAL(IRdotNetRepositories _RdotNetRepositories,
                                    IQuamdlHisoricalStockRepository _QuamdlHisoricalStockRepository
            )
        {
            QuamdlHisoricalStockRepository = _QuamdlHisoricalStockRepository;
            RdotNetRepositories = _RdotNetRepositories;
        }


        public IEnumerable<MACDHistoricalStock> generateMacd(string StockIndex)
        {

            var RowData = QuamdlHisoricalStockRepository.GetQuandlData(new RequestHistoricalStockQuandl() { Index = StockIndex }).OrderBy(x => x.Date).ToList();
            var MACD = RdotNetRepositories.getMACD(RowData);
            return MACD;

        }


    }
}
