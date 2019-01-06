using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Adapter.Interface;
using StockMarket.DAL.Interface.Persistance;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;
using StockMarket.Repository.Interface;

namespace StockMarket.Repository.Concreate {
    public class TimeSeriesRepository : ITimeSeriesRepository {
        private readonly IQuandlHistoricalStockAdapter IHistoricalStockAdapter;
        private readonly IUnitOfWork IUnitOfWork;

        public TimeSeriesRepository (IQuandlHistoricalStockAdapter _IHistoricalStockAdapter,
            IUnitOfWork _IUnitOfWork
        ) {
            IHistoricalStockAdapter = _IHistoricalStockAdapter;
            IUnitOfWork = _IUnitOfWork;
        }

        public IEnumerable<RowHistoricalStockBase> GetQuandlData (RequestHistoricalStockQuandl RequestHistoricalStockQuandl) {

            var result = IHistoricalStockAdapter.getCSVFromQuandl (RequestHistoricalStockQuandl);
            return result;
        }

        public IEnumerable<TimeSeriesIndex> GetQuandlDataIndex (RequestHistoricalStockQuandl RequestHistoricalStockQuandl) {

            var result = IHistoricalStockAdapter.getCSVFromQuandlIndex (RequestHistoricalStockQuandl);
            return result;
        }

        public string getStringFromQuandl (RequestHistoricalStockQuandl RequestHistoricalStockQuandl) {

            var result = IHistoricalStockAdapter.getStringFromQuandl (RequestHistoricalStockQuandl);
            return result;
        }

        public IEnumerable<RowHistoricalStockBase> getTimeSeriesFromDB (string StockIndex) {
            return IUnitOfWork.TimeSeriesDAL.getTimeSeriesByStockIndex (StockIndex);
        }

        public void AddRangeToDB (IEnumerable<RowHistoricalStockBase> RowHistoricalStockBase) {
            IUnitOfWork.TimeSeriesDAL.AddRange (RowHistoricalStockBase);
            IUnitOfWork.Complite ();
        }

        public void AddRangeIndexToDB (IEnumerable<TimeSeriesIndex> RowHistoricalStockBase) {
            IUnitOfWork.TimeSeriesDAL.AddRangeIndex (RowHistoricalStockBase);
            IUnitOfWork.Complite ();
        }

        public void AddRangeMACD (IEnumerable<MACDIndex> MACDIndex) {
            IUnitOfWork.MACDDAL.AddRange (MACDIndex);
            IUnitOfWork.Complite ();
        }

        public void AddRangeRSI (IEnumerable<RSIIndex> RSIIndex) {
            IUnitOfWork.RSIDAL.AddRange (RSIIndex);
            IUnitOfWork.Complite ();
        }

        public void AddRangeSO (IEnumerable<SOIndex> SOIndex) {
            IUnitOfWork.SODAL.AddRange (SOIndex);
            IUnitOfWork.Complite ();
        }

        public void AddRangeGuppy (IEnumerable<GuppyIndex> GuppyIndex) {
            IUnitOfWork.GUPPYDAL.AddRange (GuppyIndex);
            IUnitOfWork.Complite ();
        }

    }
}