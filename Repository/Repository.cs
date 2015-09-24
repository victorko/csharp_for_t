using System;
using System.Collections.Generic;

namespace DataRepository
{
    public class Repository
    {
        private readonly List<IObjectReader> objectReaders;
        private readonly List<ICollectionReader> collectionReaders;

        public Repository()
        {
            this.objectReaders = new List<IObjectReader>();
            this.collectionReaders = new List<ICollectionReader>();
        }

        public void RegisterReader(IObjectReader reader)
        {
            this.objectReaders.Add(reader);
        }

        public void RegisterReader(ICollectionReader reader)
        {
            this.collectionReaders.Add(reader);
        }

        public T Read<T>(string key = null)
        {
            foreach (var reader in this.objectReaders)
            {
                if (reader.CanRead<T>(key))
                {
                    return reader.ReadObject<T>(key);
                }
            }
            throw new InvalidOperationException("Where is no suitable reader for this type and key");
        }
        
        public IEnumerable<T> ReadMany<T>(string key = null) where T : class
        {
            foreach (var reader in this.collectionReaders)
            {
                if (reader.CanRead<T>(key))
                {
                    return reader.ReadCollection<T>(key);
                }
            }
            throw new InvalidOperationException("Where is no suitable reader for this type and key");
        }
    }
}
