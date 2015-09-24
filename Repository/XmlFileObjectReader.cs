using System.IO;
using System.Xml.Serialization;

namespace DataRepository
{
    public class XmlFileObjectReader : IObjectReader
    {
        public bool CanRead<T>(string key)
        {
            return File.Exists(key + ".xml");
        }

        public T ReadObject<T>(string key)
        {
            using (var stream = File.OpenRead(key + ".xml"))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stream);
            }
        }
    }
}
