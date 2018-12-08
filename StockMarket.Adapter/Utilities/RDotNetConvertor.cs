using RDotNet;
using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using StockMarket.Adapter.Interface;
using StockMarket.Adapter.Interface.Utilities;

namespace StockMarket.Adapter.Utilities
{
    public class RDotNetConvertor : IRDotNetConvertor
    {
        public RDotNetConvertor()
        {

        }

        public DataFrame StockBaseToDataFrame(IEnumerable<RowHistoricalStockBase> input ,REngine engine)
        {

            var dateSelect = input.Select(x => x.Date).ToArray();
            var closeSelect = input.Select(x => x.Close).ToArray();
            var openSelect = input.Select(x => x.Open).ToArray();
            var highSelect = input.Select(x => x.High).ToArray();
            var lowSelect = input.Select(x => x.Low).ToArray();
            var VolumeSelect = input.Select(x => x.Volume).ToArray();

            string[] stringDate = dateSelect.Select(x => x.ToShortDateString()).ToArray();
            double[] doubleClose = Array.ConvertAll(closeSelect, x => (double)x);
            double[] doubleOpen = Array.ConvertAll(openSelect, x => (double)x);
            double[] doubleHigh = Array.ConvertAll(highSelect, x => (double)x);
            double[] doubleLow = Array.ConvertAll(lowSelect, x => (double)x);
            double[] doubleVolume = Array.ConvertAll(VolumeSelect, x => (double)x);

            IEnumerable[] RowDatasets = new IEnumerable[6];
            RowDatasets[0] = stringDate;
            RowDatasets[1] = doubleClose;
            RowDatasets[2] = doubleOpen;
            RowDatasets[3] = doubleHigh;
            RowDatasets[4] = doubleLow;
            RowDatasets[5] = doubleVolume;

            var RowcolumnNames = new[] { "Date", "Close", "Open", "High", "Low" , "Volume" };

            return engine.CreateDataFrame(RowDatasets, columnNames: RowcolumnNames);

        }



        public IEnumerable<MACDHistoricalStock> DataFrametoMACDMapper(DataFrame dataframe)
        {

            var reslt = dataframe.ToArray();

            var date = dataframe[0].AsCharacter().ToArray();
            var Close = dataframe[1].AsNumeric().ToArray();
            var Open = dataframe[2].AsNumeric().ToArray();
            var High = dataframe[3].AsNumeric().ToArray();
            var Low = dataframe[4].AsNumeric().ToArray();
            var Volume = dataframe[5].AsNumeric().ToArray();
            var MACD = dataframe[6].AsNumeric().ToArray();
            var Signal = dataframe[7].AsNumeric().ToArray();
           
            var Date = date.Select(x => DateTime.Parse(x)).ToArray();
            var decimalClose = Array.ConvertAll(Close, x => (decimal)x);
            var decimalOpen = Array.ConvertAll(Open, x => (decimal)x);
            var decimalHigh = Array.ConvertAll(High, x => (decimal)x);
            var decimalLow = Array.ConvertAll(Low, x => (decimal)x);
            var decimalVolume = Array.ConvertAll(Volume, x => (decimal)x);

            IList<MACDHistoricalStock> result = new List<MACDHistoricalStock>();

            for (int i = 0; i < Date.Length; i++)
                result.Add(
                    new MACDHistoricalStock
                    {
                        Close = decimalClose[i],
                        Open = decimalOpen[i],
                        Date = Date[i],
                        High = decimalHigh[i],
                        Low = decimalLow[i],
                        Volume = decimalVolume[i],
                        MACD = MACD[i],
                        Signal = Signal[i],
                    }
                    );

            return result;

        }


        public IEnumerable<StochasticOscillatorHistoricalStock> DataFrametoStochasticOscillatorMapper(DataFrame dataframe)
        {
            
            var reslt = dataframe.ToArray();

            var date = dataframe[0].AsCharacter().ToArray();
            var Close = dataframe[1].AsNumeric().ToArray();
            var Open = dataframe[2].AsNumeric().ToArray();
            var High = dataframe[3].AsNumeric().ToArray();
            var Low = dataframe[4].AsNumeric().ToArray();
            var fastK = dataframe[5].AsNumeric().ToArray();
            var fastD = dataframe[6].AsNumeric().ToArray();
            var slowD = dataframe[7].AsNumeric().ToArray();

            var Date = date.Select(x => DateTime.Parse(x)).ToArray();
            var decimalClose = Array.ConvertAll(Close, x => (decimal)x);
            var decimalOpen = Array.ConvertAll(Open, x => (decimal)x);
            var decimalHigh = Array.ConvertAll(High, x => (decimal)x);
            var decimalLow = Array.ConvertAll(Low, x => (decimal)x);

            IList<StochasticOscillatorHistoricalStock> result = new List<StochasticOscillatorHistoricalStock>();

            for (int i = 0; i < Date.Length; i++)
                result.Add(
                    new StochasticOscillatorHistoricalStock
                    {
                        Close = decimalClose[i],
                        Open = decimalOpen[i],
                        Date = Date[i],
                        High = decimalHigh[i],
                        Low = decimalLow[i],
                        fastK = fastK[i],
                        fastD = fastD[i],
                        slowD = slowD[i]
                    }
                    );

            return result;
            
           

        }




        public IEnumerable<RSIHistoricalStock> DataFrametoRSIMapper(DataFrame dataframe)
        {
            /*
            var reslt = dataframe.ToArray();

            var date = dataframe[0].AsCharacter().ToArray();
            var Close = dataframe[1].AsNumeric().ToArray();
            var Open = dataframe[2].AsNumeric().ToArray();
            var High = dataframe[3].AsNumeric().ToArray();
            var Low = dataframe[4].AsNumeric().ToArray();
            var Signal = dataframe[5].AsNumeric().ToArray();
            var MACD = dataframe[6].AsNumeric().ToArray();

            var Date = date.Select(x => DateTime.Parse(x)).ToArray();
            var decimalClose = Array.ConvertAll(Close, x => (decimal)x);
            var decimalOpen = Array.ConvertAll(Open, x => (decimal)x);
            var decimalHigh = Array.ConvertAll(High, x => (decimal)x);
            var decimalLow = Array.ConvertAll(Low, x => (decimal)x);

            IList<MACDHistoricalStock> result = new List<MACDHistoricalStock>();

            for (int i = 0; i < Date.Length; i++)
                result.Add(
                    new MACDHistoricalStock
                    {
                        Close = decimalClose[i],
                        Open = decimalOpen[i],
                        Date = Date[i],
                        High = decimalHigh[i],
                        Low = decimalLow[i],
                        MACD = MACD[i],
                        Signal = Signal[i],
                    }
                    );

            return result;
            */
            return null;
        }


        public IEnumerable<GuppyHistoricalStock> DataFrametoGppyMapper(DataFrame dataframe)
        {
            /*
            var reslt = dataframe.ToArray();

            var date = dataframe[0].AsCharacter().ToArray();
            var Close = dataframe[1].AsNumeric().ToArray();
            var Open = dataframe[2].AsNumeric().ToArray();
            var High = dataframe[3].AsNumeric().ToArray();
            var Low = dataframe[4].AsNumeric().ToArray();
            var Signal = dataframe[5].AsNumeric().ToArray();
            var MACD = dataframe[6].AsNumeric().ToArray();

            var Date = date.Select(x => DateTime.Parse(x)).ToArray();
            var decimalClose = Array.ConvertAll(Close, x => (decimal)x);
            var decimalOpen = Array.ConvertAll(Open, x => (decimal)x);
            var decimalHigh = Array.ConvertAll(High, x => (decimal)x);
            var decimalLow = Array.ConvertAll(Low, x => (decimal)x);

            IList<MACDHistoricalStock> result = new List<MACDHistoricalStock>();

            for (int i = 0; i < Date.Length; i++)
                result.Add(
                    new MACDHistoricalStock
                    {
                        Close = decimalClose[i],
                        Open = decimalOpen[i],
                        Date = Date[i],
                        High = decimalHigh[i],
                        Low = decimalLow[i],
                        MACD = MACD[i],
                        Signal = Signal[i],
                    }
                    );

            return result;
            */
            return null;
        }


    }
}
