using StockMarket.Adapter.Interface;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Persistence.Repositories
{
    public class QuandlHisoricalStockRepository : IQuamdlHisoricalStockRepository
    {
        private readonly IQuandlHistoricalStockAdapter IHistoricalStockAdapter;

        public QuandlHisoricalStockRepository(IQuandlHistoricalStockAdapter _IHistoricalStockAdapter)
        {
            IHistoricalStockAdapter = _IHistoricalStockAdapter;
        }


        public IEnumerable<RowHistoricalStockBase> GetQuandlData (RequestHistoricalStockQuandl RequestHistoricalStockQuandl)
        {

            var result = IHistoricalStockAdapter.getCSVFromQuandl(RequestHistoricalStockQuandl);
            return result;
        }

        public string getStringFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStockQuandl)
        {

            var result = IHistoricalStockAdapter.getStringFromQuandl(RequestHistoricalStockQuandl);
            return result;
        }
    }
}
