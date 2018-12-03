using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockMarket.Adapter;
using StockMarket.Adapter.Interface;

namespace StockMarket.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricalStickDataController : ControllerBase
    {

        private readonly IHistoricalStockAdapter HistoricalStockAdapter;
        public HistoricalStickDataController(IHistoricalStockAdapter _HistoricalStockAdapter)
        {
            HistoricalStockAdapter = _HistoricalStockAdapter;
        }

        [HttpGet("[action]")]
        public async Task<object> get() {


            var result = await HistoricalStockAdapter.GetHistorical();


            var obj = JsonConvert.DeserializeObject(result);


            return obj;

        }

        [HttpGet("[action]")]
        public string getCSV()
        {
            var result =  HistoricalStockAdapter.getCSV();
            return result;
        }



        
    }
}