using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StockMarket.Model;
using StockMarket.Model.Base;

namespace StockMarket.Adapter.Interface {
    public interface IQuandlHistoricalStockAdapter {
        IEnumerable<TimeSeriesIndex> getCSVFromQuandlIndex (RequestHistoricalStockQuandl RequestHistoricalStock);
        IEnumerable<RowHistoricalStockBase> getCSVFromQuandl (RequestHistoricalStockQuandl RequestHistoricalStock);
        string getStringFromQuandl (RequestHistoricalStockQuandl RequestHistoricalStock);

    }
}