namespace _05_10
{
    internal interface IMyGenericQueue<T>
    {
        int Count { get; }
        bool Empty { get; }

        T Dequeue();
        void Enqueue(T val);
    }
}