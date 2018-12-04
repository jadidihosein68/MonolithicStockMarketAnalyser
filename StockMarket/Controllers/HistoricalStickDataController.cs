using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using StockMarket.Adapter;
using StockMarket.Adapter.Interface;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using StockMarket.Model.Configuration;

namespace StockMarket.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricalStickDataController : ControllerBase
    {

        private readonly IHisoricalStockRepository IHisoricalStockRepository;
        private readonly AppConfiguration AppConfiguration;
        public HistoricalStickDataController(IHisoricalStockRepository _IHisoricalStockRepository, IOptions<AppConfiguration> _AppConfiguration)
        {
            IHisoricalStockRepository = _IHisoricalStockRepository;
            AppConfiguration = _AppConfiguration.Value;
        }

        [HttpGet("[action]")]
        public IEnumerable<RowHistoricalStockBase> GetQuadel(string StockIndex)
        {
            var result = IHisoricalStockRepository.GetQuandlData(new RequestHistoricalStockQuandl() { api_key = AppConfiguration.QuandlAPIKey, Index = StockIndex });
            return result;
        }




    }
}