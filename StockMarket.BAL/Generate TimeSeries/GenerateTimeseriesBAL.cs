using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using StockMarket.BAL.Generate_TimeSeries.Interfaces;
using StockMarket.DAL.Interface.Persistance.Repositories;
using StockMarket.Model;
using StockMarket.Model.DTO;
using StockMarket.Model.Quantitative;
using StockMarket.Repository.Interface;

namespace StockMarket.BAL.Generate_TimeSeries {
    public class GenerateTimeseriesBAL : IGenerateTimeseriesBAL {
        private readonly IRdotNetRepositories RdotNetRepositories;
        private readonly ITimeSeriesRepository TimeSeriesRepository;
        private readonly IMapper mapper;
        public GenerateTimeseriesBAL (
            IMapper _mapper,
            IRdotNetRepositories _RdotNetRepositories,
            ITimeSeriesRepository _TimeSeriesRepository
        ) {
            TimeSeriesRepository = _TimeSeriesRepository;
            RdotNetRepositories = _RdotNetRepositories;
            mapper = _mapper;
        }

        public IEnumerable<MACDHistoricalStock> generateMacd (string StockIndex) {

            var RowData = TimeSeriesRepository.GetQuandlData (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var MACD = RdotNetRepositories.getMACD (RowData);
            return MACD;

        }

        public IEnumerable<MACDIndex> generateMACDIndex (string StockIndex) {

            var RowData = TimeSeriesRepository.GetQuandlDataIndex (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var MACD = RdotNetRepositories.getMACDIndex (RowData);
            return MACD;

        }

        public IEnumerable<SOIndex> generateSOIndex (string StockIndex) {

            var RowData = TimeSeriesRepository.GetQuandlDataIndex (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var StochasticOscillator = RdotNetRepositories.getSOIndex (RowData);
            return StochasticOscillator;

        }

        public IEnumerable<RSIIndex> generateRSIIndex (string StockIndex) {

            var RowData = TimeSeriesRepository.GetQuandlDataIndex (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var RSI = RdotNetRepositories.getRSIIndex (RowData);
            return RSI;

        }

        public IEnumerable<GuppyIndex> generateGuppyIndex (string StockIndex) {

            var RowData = TimeSeriesRepository.GetQuandlDataIndex (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var RSI = RdotNetRepositories.getGuppyIndex (RowData);
            return RSI;

        }

        public IEnumerable<StochasticOscillatorHistoricalStock> generateStochasticOscillator (string StockIndex) {

            var RowData = TimeSeriesRepository.GetQuandlData (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var StochasticOscillator = RdotNetRepositories.GetStochasticOscillator (RowData);
            return StochasticOscillator;

        }

        public IEnumerable<RSIHistoricalStock> generateRSI (string StockIndex) {

            var RowData = TimeSeriesRepository.GetQuandlData (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var RSI = RdotNetRepositories.GetRSI (RowData);
            return RSI;

        }

        public IEnumerable<GuppyHistoricalStock> generateGuppy (string StockIndex) {

            var RowData = TimeSeriesRepository.GetQuandlData (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var RSI = RdotNetRepositories.GetGuppy (RowData);
            return RSI;

        }

        public bool SyncTimeSeries (string StockIndex) {

            var maxdate = DateTime.MinValue;
            var DataFromQuadel = TimeSeriesRepository.GetQuandlData (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            var DataFromDB = TimeSeriesRepository.getTimeSeriesFromDB (StockIndex);
            if (DataFromDB.Any ())
                maxdate = DataFromDB.Select (x => x.Date).Max (c => c.Date);

            var toinsert = DataFromQuadel.Where (x => x.Date > maxdate).ToList ();
            toinsert.ForEach (c => c.StockIndex = StockIndex);
            TimeSeriesRepository.AddRangeToDB (toinsert);

            return true;
        }

        public bool SyncTimeSeriesIndex (string StockIndex) {

            var maxdate = DateTime.MinValue;
            var DataFromQuadel = TimeSeriesRepository.GetQuandlDataIndex (new RequestHistoricalStockQuandl () { Index = StockIndex }).OrderBy (x => x.Date).ToList ();
            //var DataFromDB = TimeSeriesRepository.getTimeSeriesFromDB(StockIndex);
            //if (DataFromDB.Any())
            //  maxdate = DataFromDB.Select(x => x.Date).Max(c => c.Date);

            var toinsert = DataFromQuadel.Where (x => x.Date > maxdate).ToList ();
            toinsert.ForEach (c => c.StockIndex = StockIndex);

            //var DTO = mapper.Map<List<TimeSeriesIndex>, List<TimeSeriesDTO>>(toinsert);
            TimeSeriesRepository.AddRangeIndexToDB (toinsert);

            return true;
        }

    }
}