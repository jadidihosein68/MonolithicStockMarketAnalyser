using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Interface.Persistance.Repositories
{
    public interface IHisoricalStockRepository
    {
        IEnumerable<RowHistoricalStockBase> GetQuandlData(RequestHistoricalStockQuandl RequestHistoricalStockQuandl);
    }
}
