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
using StockMarket.Model;
using StockMarket.Model.Base;
using StockMarket.Model.Configuration;
using StockMarket.Repository.Interface;

namespace StockMarket.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricalStickDataController : ControllerBase
    {

        private readonly IQuamdlHisoricalStockRepository IHisoricalStockRepository;
        public HistoricalStickDataController(IQuamdlHisoricalStockRepository _IHisoricalStockRepository)
        {
            IHisoricalStockRepository = _IHisoricalStockRepository;
        }

        [HttpGet("[action]")]
        public IEnumerable<RowHistoricalStockBase> GetQuadel(string StockIndex)
        {
            var result = IHisoricalStockRepository.GetQuandlData(new RequestHistoricalStockQuandl() { Index = StockIndex });
            return result;
        }


    }
}