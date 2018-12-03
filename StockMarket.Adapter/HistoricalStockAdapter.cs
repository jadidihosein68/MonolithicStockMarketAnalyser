using StockMarket.Adapter.Interface;
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

        public async Task<string> GetHistorical()
        {

            var client = httpClientFactory.CreateClient();
            var response = await client.GetAsync("https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=MSFT&interval=5min&outputsize=full&datatype=json&apikey=ZUIAKZL5BZM0D24V");
            if (response.IsSuccessStatusCode)
            {

                var responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }

            return "";
        }

        public string getCSV()
        {

            return getCSV2();
        }

        private string getCSV1() {

            var url = "https://www.alphavantage.co/query?function=FX_DAILY&from_symbol=EUR&to_symbol=USD&apikey=ZUIAKZL5BZM0D24V&datatype=csv";

            var req = (HttpWebRequest)WebRequest.Create(url);
            var resp = (HttpWebResponse)req.GetResponse();
            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();
            return results;

        }

        private string getCSV2()
        {

            var URL = "https://www.alphavantage.co/query?function=FX_DAILY&from_symbol=EUR&to_symbol=USD&apikey=ZUIAKZL5BZM0D24V&datatype=csv";
            var client = new System.Net.WebClient();
            var result  = client.DownloadString(URL);
            string[] temp = result.Split('\n');
            return result;
        }







    }


    public class RequestHistoricalStock {

        public string function { get; set; }
        public string from_symbol { get; set; } = "EUR";
        public string to_symbol { get; set; }
        public string datatype { get; set; }
        
    }
}
