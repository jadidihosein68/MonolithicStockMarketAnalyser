using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Adapter.Interface
{
    public interface IHistoricalStockAdapter
    {
        Task<string> GetHistorical();
        string getCSV();
    }
}
