using CsvHelper;
using StockMarket.Adapter.Interface;
using StockMarket.Adapter.Utilities;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Adapter
{
    public class HistoricalStockAdapter : IHistoricalStockAdapter
    {
        private readonly IHttpClientFactory httpClientFactory;

        public HistoricalStockAdapter(IHttpClientFactory _httpClientFactory)
        {
            this.httpClientFactory = _httpClientFactory;
        }

        public IEnumerable<RowHistoricalStockBase> getCSVFromQuandl(RequestHistoricalStockQuandl RequestHistoricalStock)
        {
            var URL = $"https://www.quandl.com/api/v3/datasets/WIKI/FB/data.{RequestHistoricalStock.DataType}?api_key={RequestHistoricalStock.api_key}";
            var client = new System.Net.WebClient();
            var result = client.DownloadString(URL);
            return (new CSVDeserializer().Decerialize<RowHistoricalStockBase>(result));
        }


    }

}
