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

        public IEnumerable<RSIHistoricalStock> CalculateRSI(IEnumerable<RowHistoricalStockBase> input)
        {
            
            var StockDataFrame = RDotNetConvertor.StockBaseToDataFrame(input, engine);
            engine.SetSymbol("datasets", StockDataFrame);
            engine.Evaluate($"rsi <- RSI(datasets[, 'Close'])");
            engine.Evaluate("datasets$Rsi <- (rsi)");
            var result = engine.Evaluate("finalReslt <- data.frame(datasets)").AsDataFrame();
            var final = RDotNetConvertor.DataFrametoRSIMapper(result);

            return final;
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

        public IEnumerable<GuppyHistoricalStock> CalculateGuppy(IEnumerable<RowHistoricalStockBase> input)
        {
            var StockDataFrame = RDotNetConvertor.StockBaseToDataFrame(input, engine);
            engine.SetSymbol("datasets", StockDataFrame);
            engine.Evaluate($"gmma <- GMMA(datasets[, 'Close'])");
            engine.Evaluate("datasets$shortlag3 <- (gmma[,'short lag 3'])");
            engine.Evaluate("datasets$shortlag5 <- (gmma[,'short lag 5'])");
            engine.Evaluate("datasets$shortlag8 <- (gmma[,'short lag 8'])");
            engine.Evaluate("datasets$shortlag10 <- (gmma[,'short lag 10'])");
            engine.Evaluate("datasets$shortlag12 <- (gmma[,'short lag 12'])");
            engine.Evaluate("datasets$shortlag15 <- (gmma[,'short lag 15'])");
            engine.Evaluate("datasets$longlag30 <- (gmma[,'long lag 30'])");
            engine.Evaluate("datasets$longlag35 <- (gmma[,'long lag 35'])");
            engine.Evaluate("datasets$longlag40 <- (gmma[,'long lag 40'])");
            engine.Evaluate("datasets$longlag45 <- (gmma[,'long lag 45'])");
            engine.Evaluate("datasets$longlag50 <- (gmma[,'long lag 50'])");
            engine.Evaluate("datasets$longlag60 <- (gmma[,'long lag 60'])");
            var result = engine.Evaluate("finalReslt <- data.frame(datasets)").AsDataFrame();
            var final = RDotNetConvertor.DataFrametoGuppyMapper(result);
            return final;

        }
        
        /*
        ~RdotNetAdapter()
        {
            engine.Dispose();
        }*/

    }
}
