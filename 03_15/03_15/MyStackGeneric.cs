// See https://aka.ms/new-console-template for more information
internal class MyStack<T>
{
    private T[] data;
    private int _capacity = 16;
    private int _count = 0;
    public bool IsEmpty
    {
        get
        {
            return _count == 0;
        }
    }
    public int Capacity
    {
        get
        {
            return _capacity;
        }
    }
    public int Count
    {
        get
        {
            return _count;
        }
    }
    public MyStack()
    {
        data = new T[_capacity];
    }

    internal void Push(T val)
    {
        Console.WriteLine($"Se adauga valoarea {val} in stiva");
        if (_count < _capacity)
        {
            data[_count] = val;
            _count++;
        }
        else
        {
            _capacity *= 2;
            T[] vs = new T[_capacity];
            for (int i = 0; i < _count; i++)
            {
                vs[i] = data[i];
            }
            data = vs;

            data[_count] = val;
            _count++;
        }
    }

    internal T Peek()
    {
        if (IsEmpty)
        {
            throw new StackEmptyException();
        }

        return data[_count - 1];
    }

    internal T Pop()
    {
        if (_count > 0)
        {
            _count--;
            return data[_count];
        }
        else
            throw new StackEmptyException("S-a incercat eliminarea unui element dintr-o stiva goala");
    }
}