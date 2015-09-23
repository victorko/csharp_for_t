namespace DataRepository
{
    public interface IObjectReader<out T>
    {
        bool CanRead(string key);
        T Read(string key);
    }
}
