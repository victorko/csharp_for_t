using System.IO;
using System.Xml.Serialization;

namespace DataRepository
{
    public class XmlFileObjectReader<T> : IObjectReader<T>
    {
        public bool CanRead(string key)
        {
            return File.Exists(key + ".xml");
        }

        public T Read(string key)
        {
            using (var stream = File.OpenRead(key + ".xml"))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}
