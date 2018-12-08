using RDotNet;
using StockMarket.Adapter.Interface;
using StockMarket.Adapter.Interface.Utilities;
using StockMarket.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket.Adapter
{
    public class RdotNetAdapter : IRdotNetAdapter
    {
        private REngine engine;
        private readonly IRDotNetConvertor RDotNetConvertor;
        public RdotNetAdapter(IRDotNetConvertor _RDotNetConvertor)
        {
            REngine.SetEnvironmentVariables();
            engine = REngine.GetInstance(); // imp singletone 
            engine.Evaluate("library(TTR)");
            RDotNetConvertor = _RDotNetConvertor;

        }

        public IEnumerable<MACDHistoricalStock> CalculateMACD(IEnumerable<RowHistoricalStockBase> input)
        {

            var StockDataFrame = RDotNetConvertor.StockBaseToDataFrame(input, engine);
            engine.SetSymbol("datasets", StockDataFrame);
            engine.Evaluate($"macd <- MACD(datasets[,'Close'], 12, 26, 9 ,  maType = 'EMA')");
            engine.Evaluate("datasets$MADC <- (macd[,'macd'])");
            engine.Evaluate("datasets$Signal <- (macd[,'signal'])");
            var result = engine.Evaluate("finalReslt <- data.frame(datasets)").AsDataFrame();
            var final = RDotNetConvertor.DataFrametoMACDMapper(result);

            return final;
        }

        public IEnumerable<MACDHistoricalStock> CalculateRSI(IEnumerable<RowHistoricalStockBase> input)
        {
            /*
            var StockDataFrame = RDotNetConvertor.StockBaseToDataFrame(input, engine);
            engine.SetSymbol("datasets", StockDataFrame);
            engine.Evaluate($"macd <- MACD(datasets[,'Close'], 12, 26, 9 ,  maType = 'EMA')");
            engine.Evaluate("datasets$MADC <- (macd[,'macd'])");
            engine.Evaluate("datasets$Signal <- (macd[,'signal'])");
            var result = engine.Evaluate("finalReslt <- data.frame(datasets)").AsDataFrame();
            var final = RDotNetConvertor.DataFrametoMACDMapper(result);

            return final;
           */
            return null;
        }

        public IEnumerable<StochasticOscillatorHistoricalStock> CalculateStochasticOscillator(IEnumerable<RowHistoricalStockBase> input)
        {

            var StockDataFrame = RDotNetConvertor.StockBaseToDataFrame(input, engine);
            engine.SetSymbol("datasets", StockDataFrame);
            engine.Evaluate($"stoch2MA <- stoch(datasets[, c('High', 'Low', 'Close')], maType = list(list(SMA), list(EMA, wilder = TRUE), list(SMA)))");
            engine.Evaluate("datasets$fastK <- (stoch2MA[,'fastK'])");
            engine.Evaluate("datasets$fastD <- (stoch2MA[,'fastD'])");
            engine.Evaluate("datasets$slowD <- (stoch2MA[,'slowD'])");
            var result = engine.Evaluate("finalReslt <- data.frame(datasets)").AsDataFrame();
            var final = RDotNetConvertor.DataFrametoStochasticOscillatorMapper(result);
            return final;
        }





        public IEnumerable<MACDHistoricalStock> CalculateGuppy(IEnumerable<RowHistoricalStockBase> input)
        {
            /*
            var StockDataFrame = RDotNetConvertor.StockBaseToDataFrame(input, engine);
            engine.SetSymbol("datasets", StockDataFrame);
            engine.Evaluate($"macd <- MACD(datasets[,'Close'], 12, 26, 9 ,  maType = 'EMA')");
            engine.Evaluate("datasets$MADC <- (macd[,'macd'])");
            engine.Evaluate("datasets$Signal <- (macd[,'signal'])");
            var result = engine.Evaluate("finalReslt <- data.frame(datasets)").AsDataFrame();
            var final = RDotNetConvertor.DataFrametoMACDMapper(result);

            return final;
            */
            return null;
        }

        ~RdotNetAdapter()
        {
            engine.Dispose();
        }

    }
}
