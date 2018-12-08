﻿using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.BAL.Generate_TimeSeries.Interfaces
{
    public interface IGenerateTimeseriesBAL
    {
        IEnumerable<MACDHistoricalStock> generateMacd(string StockIndex);
    }
}
