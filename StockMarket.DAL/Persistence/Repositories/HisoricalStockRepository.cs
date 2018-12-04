using StockMarket.Adapter.Interface;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.Repositories
{
    public class HisoricalStockRepository : IHisoricalStockRepository
    {
        private readonly IHistoricalStockAdapter IHistoricalStockAdapter;

        public HisoricalStockRepository(IHistoricalStockAdapter _IHistoricalStockAdapter)
        {
            IHistoricalStockAdapter = _IHistoricalStockAdapter;
        }


        public IEnumerable<RowHistoricalStockBase> GetQuandlData (RequestHistoricalStockQuandl RequestHistoricalStockQuandl)
        {

            var result = IHistoricalStockAdapter.getCSVFromQuandl(RequestHistoricalStockQuandl);
            return result;
        }
    }
}
