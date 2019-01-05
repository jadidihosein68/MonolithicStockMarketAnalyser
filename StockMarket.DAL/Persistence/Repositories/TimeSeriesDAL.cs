using StockMarket.DAL.DBContext;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using StockMarket.Model;

namespace StockMarket.DAL.Persistence.Repositories
{
    public class TimeSeriesDAL : ITimeSeriesDAL
    {
        private readonly ISalDbContext context;
        public TimeSeriesDAL(ISalDbContext _context)
        {
            context = _context;
        }
        public void AddRange(IEnumerable<RowHistoricalStockBase> DataSet) {
            context.TimeSeries.AddRange(DataSet);
        }


        public void AddRangeIndex(IEnumerable<TimeSeriesIndex> DataSet)
        {
            context.TimeSeriesIndex.AddRange(DataSet);
        }

        public IEnumerable <RowHistoricalStockBase> getTimeSeriesByStockIndex(string StockIndex)
        {
            return context.TimeSeries.Where(c=>c.StockIndex== StockIndex);
        }


    }
}
