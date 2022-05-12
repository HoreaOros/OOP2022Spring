public interface IGenericQueue<T>
{
    int Count { get; }
    bool Empty { get; }

    T Dequeue();
    void Enqueue(T val);
}