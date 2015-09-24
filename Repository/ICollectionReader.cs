using System.Collections.Generic;

namespace DataRepository
{
    public interface ICollectionReader
    {
        bool CanRead<T>(string key);

        IEnumerable<T> ReadCollection<T>(string key);
    }
}
