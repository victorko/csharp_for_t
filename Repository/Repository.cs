using System;
using System.Collections.Generic;

namespace DataRepository
{
    public class Repository
    {
        private readonly List<IObjectReader<object>> readers;

        public Repository()
        {
            this.readers = new List<IObjectReader<object>>();
        }

        public void RegisterReader<T>(IObjectReader<T> reader) where T : class
        {
            this.readers.Add(reader);
        }

        public T Read<T>(string key = null) where T : class
        {
            foreach (var reader in this.readers)
            {
                var typedReader = reader as IObjectReader<T>;
                if (typedReader != null && typedReader.CanRead(key))
                {
                    return typedReader.Read(key);
                }
            }
            throw new InvalidOperationException("Where is no suitable reader for this type and key");
        }


        public IEnumerable<T> ReadMany<T>(string key = null) where T : class
        {
            foreach (var reader in this.readers)
            {
                var typedReader = reader as IObjectReader<IEnumerable<T>>;
                if (typedReader != null && typedReader.CanRead(key))
                {
                    return typedReader.Read(key);
                }
            }
            throw new InvalidOperationException("Where is no suitable reader for this type and key");
        }
    }
}
