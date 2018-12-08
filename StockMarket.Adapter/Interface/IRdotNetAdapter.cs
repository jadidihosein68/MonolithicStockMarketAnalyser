﻿using StockMarket.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Adapter.Interface
{
    public interface IRdotNetAdapter
    {
        IEnumerable<MACDHistoricalStock> CalculateMACD(IEnumerable<RowHistoricalStockBase> input);
    }
}
