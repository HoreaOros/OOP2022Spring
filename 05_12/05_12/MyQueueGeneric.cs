// 2. Basic generic queue implementation
public class MyQueue<T>
{
    #region Fields
    T[] data;
    int capacity;
    int head, tail;
    int count;
    #endregion
    #region Ctors
    public MyQueue() : this(42)
    {
    }
    public MyQueue(int capacity)
    {
        this.capacity = capacity;
        data = new T[capacity];
        head = tail = 0;
        count = 0;
    }
    #endregion

    #region Properties
    public int Count => count;
    public bool Empty => count == 0;
    #endregion

    #region Methods
    public void Enqueue(T val)
    {
        if (count < capacity)
        {
            if (tail >= data.Length)
            {
                tail = 0;
            }
            data[tail++] = val;
            Logger.Instance.Log($"Am adaugat valoarea <{val}> in coada");
            count++;
        }
        else
            throw new QueueFullException("Coada este plina");
    }
    public T Dequeue()
    {
        if (count > 0)
        {
            T val = data[head];
            head = (head + 1) % capacity;
            count--;
            return val;
        }
        else
            throw new QueueEmptyException("Coada este goala");
    }
    #endregion
}