// See https://aka.ms/new-console-template for more information
internal class MyQueue
{
    #region Data
    private int[] data;
    private int left = 0;
    private int right = 0;
    private int count = 0;
    #endregion
    #region Ctors
    public MyQueue(): this(42)
    {
        
    }

    

    public MyQueue(int n)
    {
        data = new int[n];
    }
    #endregion

    #region Properties
    public bool Empty 
    {
        get
        {
            return count == 0;
        }
    }
    public int Count
    { 
        get 
        { 
            return count; 
        } 
    }
    #endregion
    #region Methods
    public void Enqueue(int val)
    {
        if (count < data.Length)
        {
            if (right < data.Length)
            {
                data[right++] = val;
            }
            else
            {
                data[0] = val;
                right = 1;
            }
            count++;
        }
        else
            throw new QueueFullException("Coada este plina");

    }
    internal int Dequeue()
    {
        int result;
        if (count > 0)
        {
            result = data[left];
            left = (left + 1) % data.Length;
            count--;
            return result;
        }
        else
            throw new QueueEmptyException("Coada este goala");
    }
    #endregion

}