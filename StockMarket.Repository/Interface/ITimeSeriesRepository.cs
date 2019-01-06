using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Quantitative;

namespace StockMarket.Repository.Interface {
    public interface ITimeSeriesRepository {
        IEnumerable<TimeSeriesIndex> GetQuandlDataIndex (RequestHistoricalStockQuandl RequestHistoricalStockQuandl);
        IEnumerable<RowHistoricalStockBase> GetQuandlData (RequestHistoricalStockQuandl RequestHistoricalStockQuandl);
        string getStringFromQuandl (RequestHistoricalStockQuandl RequestHistoricalStockQuandl);
        IEnumerable<RowHistoricalStockBase> getTimeSeriesFromDB (string StockIndex);
        void AddRangeToDB (IEnumerable<RowHistoricalStockBase> RowHistoricalStockBase);
        void AddRangeIndexToDB (IEnumerable<TimeSeriesIndex> RowHistoricalStockBase);

        void AddRangeGuppy (IEnumerable<GuppyIndex> GuppyIndex);
        void AddRangeSO (IEnumerable<SOIndex> SOIndex);
        void AddRangeRSI (IEnumerable<RSIIndex> RSIIndex);
        void AddRangeMACD (IEnumerable<MACDIndex> MACDIndex);
        StockSummary getStockSummaryByIndex (string StockIndex);
        IEnumerable<StockSummary> getAllStockSumaries ();

    }
}