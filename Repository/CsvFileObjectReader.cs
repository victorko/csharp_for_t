using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataRepository
{
    public class CsvFileObjectReader<T> : IObjectReader<IEnumerable<T>>
    {
        public bool CanRead(string key)
        {
            return File.Exists(key + ".csv");
        }

        public IEnumerable<T> Read(string key)
        {
            using (var stream = File.OpenText(key + ".csv"))
            {
                var csvReader = new CsvReader(stream);
                return csvReader.GetRecords<T>().ToList();
            }
        }
    }
}
