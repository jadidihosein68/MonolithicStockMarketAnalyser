using StockMarket.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DAL.Interface.Persistance.Repositories
{
    public interface ITimeSeriesDAL
    {
        void AddRange(IEnumerable<RowHistoricalStockBase> DataSet);
        IEnumerable<RowHistoricalStockBase> getTimeSeriesByStockIndex(string StockIndex);

    }
}
