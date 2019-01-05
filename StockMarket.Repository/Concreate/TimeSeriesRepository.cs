using StockMarket.Adapter.Interface;
using StockMarket.DAL.Interface.Persistance;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Repository.Concreate
{
    public class TimeSeriesRepository : ITimeSeriesRepository
    {
        private readonly IQuandlHistoricalStockAdapter IHistoricalStockAdapter;
        private readonly IUnitOfWork IUnitOfWork;

        public TimeSeriesRepository(IQuandlHistoricalStockAdapter _IHistoricalStockAdapter,
            IUnitOfWork _IUnitOfWork
            )
        {
            IHistoricalStockAdapter = _IHistoricalStockAdapter;
            IUnitOfWork = _IUnitOfWork;
        }


        public IEnumerable<RowHistoricalStockBase> GetQuandlData(RequestHistoricalStockQuandl RequestHistoricalStockQuandl)
        {

            var result = IHistoricalStockAdapter.getCSVFromQuandl(RequestHistoricalStockQuandl);
            return result;
        }

        public string getStringFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStockQuandl)
        {

            var result = IHistoricalStockAdapter.getStringFromQuandl(RequestHistoricalStockQuandl);
            return result;
        }


        public IEnumerable<RowHistoricalStockBase> getTimeSeriesFromDB(string StockIndex)
        {
            return IUnitOfWork.TimeSeriesDAL.getTimeSeriesByStockIndex(StockIndex);
        }

        public void AddRangeToDB(IEnumerable<RowHistoricalStockBase> RowHistoricalStockBase)
        {
            IUnitOfWork.TimeSeriesDAL.AddRange(RowHistoricalStockBase);
            IUnitOfWork.Complite();
        }


    }
}
