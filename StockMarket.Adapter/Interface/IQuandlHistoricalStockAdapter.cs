using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Adapter.Interface
{
    public interface IQuandlHistoricalStockAdapter
    {
        IEnumerable<RowHistoricalStockBase> getCSVFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStock);
        string getStringFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStock);
    }
}
