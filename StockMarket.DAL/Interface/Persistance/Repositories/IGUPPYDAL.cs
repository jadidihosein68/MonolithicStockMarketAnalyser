using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Model.Quantitative;

namespace StockMarket.DAL.Interface.Persistance.Repositories {
    public interface IGUPPYDAL {
        void AddRange (IEnumerable<GuppyIndex> DataSet);
    }
}