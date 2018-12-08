using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Interface.Persistance.Repositories
{
    public interface IQuamdlHisoricalStockRepository
    {
        IEnumerable<RowHistoricalStockBase> GetQuandlData(RequestHistoricalStockQuandl RequestHistoricalStockQuandl);
        string getStringFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStockQuandl);

    }
}
