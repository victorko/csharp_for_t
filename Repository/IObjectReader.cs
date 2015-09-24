namespace DataRepository
{
    public interface IObjectReader
    {
        bool CanRead<T>(string key);

        T ReadObject<T>(string key);
    }
}
