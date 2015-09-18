namespace Examples.Generics
{
    public interface IStack<T>
    {
        bool IsEmpty { get; }

        void Push(T item);

        T Pop();
    }
}
