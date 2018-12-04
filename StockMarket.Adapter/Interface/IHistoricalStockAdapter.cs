using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Adapter.Interface
{
    public interface IHistoricalStockAdapter
    {
        IEnumerable<RowHistoricalStockBase> getCSVFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStock);
    }
}
