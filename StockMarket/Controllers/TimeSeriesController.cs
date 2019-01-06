using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Adapter.Interface;
using StockMarket.BAL.Generate_TimeSeries;
using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.Model;
using StockMarket.Model.Quantitative;

namespace StockMarket.Core.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class TimeSeriesController : ControllerBase {

        private readonly IGenerateTimeseriesBAL generateTimeseriesBAL;

        public TimeSeriesController (IGenerateTimeseriesBAL _generateTimeseriesBAL) {
            generateTimeseriesBAL = _generateTimeseriesBAL;
        }

        [HttpGet ("[action]")]
        public IEnumerable<MACDHistoricalStock> generateMacd (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateMacd (StockIndex);

            return result;
        }

        [HttpGet ("[action]")]
        public IEnumerable<MACDIndex> generateMacdIndex (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateMACDIndex (StockIndex);

            return result;
        }

        [HttpGet ("[action]")]
        public IEnumerable<RSIIndex> generateRSIIndex (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateRSIIndex (StockIndex);

            return result;
        }

        [HttpGet ("[action]")]
        public IEnumerable<SOIndex> generateSOIndex (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateSOIndex (StockIndex);

            return result;
        }

        [HttpGet ("[action]")]
        public IEnumerable<GuppyIndex> generateGuppyIndex (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateGuppyIndex (StockIndex);

            return result;
        }

        [HttpGet ("[action]")]
        public IEnumerable<StochasticOscillatorHistoricalStock> generateStochasticOscillator (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateStochasticOscillator (StockIndex);

            return result;
        }

        [HttpGet ("[action]")]
        public IEnumerable<RSIHistoricalStock> generateRSI (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateRSI (StockIndex);

            return result;
        }

        [HttpGet ("[action]")]
        public IEnumerable<GuppyHistoricalStock> generateGuppy (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;

            var result = generateTimeseriesBAL.generateGuppy (StockIndex);

            return result;
        }

        [HttpGet ("[action]")]
        public ActionResult SyncTimeSeries (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;
            var result = generateTimeseriesBAL.SyncTimeSeries (StockIndex);
            return Ok (result);
        }

        [HttpGet ("[action]")]
        public ActionResult SyncTimeSeriesIndex (string StockIndex) {
            StockIndex = string.IsNullOrEmpty (StockIndex) ? "FB" : StockIndex;
            var result = generateTimeseriesBAL.SyncTimeSeriesIndex (StockIndex);
            return Ok (result);

        }

        [HttpGet ("[action]")]
        public ActionResult getStockSmmeries (string StockIndex) {
            var result = generateTimeseriesBAL.getAllStockSumaries ();
            return Ok (result);

        }

    }
}