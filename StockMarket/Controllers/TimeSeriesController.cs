﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Adapter.Interface;
using StockMarket.BAL.Generate_TimeSeries;
using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;

namespace StockMarket.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSeriesController : ControllerBase
    {

        private readonly IGenerateTimeseriesBAL generateTimeseriesBAL;

        public TimeSeriesController(IGenerateTimeseriesBAL _generateTimeseriesBAL )
        {
            generateTimeseriesBAL = _generateTimeseriesBAL;
        }

        [HttpGet("[action]")]
        public IEnumerable<MACDHistoricalStock> generateMacd(string StockIndex)
        {
            StockIndex = string.IsNullOrEmpty(StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateMacd(StockIndex);

            return result;
        }

    }
}