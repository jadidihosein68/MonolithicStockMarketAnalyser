using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CsvHelper;

namespace StockMarket.Adapter.Utilities
{
    public class CSVDeserializer
    {

        public IEnumerable<T> Decerialize<T> ( string CSV) where T : class
        {
            TextReader TextReader = new StringReader(CSV);
            var csv = new CsvReader(TextReader);
            var records = csv.GetRecords<T>();
            return records;
        }
    }
}
