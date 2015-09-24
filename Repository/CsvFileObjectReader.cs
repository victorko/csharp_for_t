using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataRepository
{
    public class CsvFileObjectReader : ICollectionReader
    {
        public bool CanRead<T>(string key)
        {
            return File.Exists(key + ".csv");
        }

        public IEnumerable<T> ReadCollection<T>(string key)
        {
            using (var stream = File.OpenText(key + ".csv"))
            {
                var csvReader = new CsvReader(stream);
                return csvReader.GetRecords<T>().ToList();
            }
        }
    }
}
