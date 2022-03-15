// See https://aka.ms/new-console-template for more information
internal class MyStack
{
    private int[] data;
    private int _capacity = 16;
    private int _count = 0;

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
        data = new int[_capacity];
    }

    internal void Push(int val)
    {
        
    }
}