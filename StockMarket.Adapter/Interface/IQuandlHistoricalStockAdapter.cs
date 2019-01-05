using StockMarket.Model;
using StockMarket.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Adapter.Interface
{
    public interface IQuandlHistoricalStockAdapter
    {
        IEnumerable<TimeSeries> getCSVFromQuandlIndex(RequestHistoricalStockQuandl RequestHistoricalStock);
        IEnumerable<RowHistoricalStockBase> getCSVFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStock);
        string getStringFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStock);

    }
}
