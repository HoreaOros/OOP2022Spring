using System.Text;

internal class MultiCounter
{
    private int size;
    private Counter[] counters;
    public MultiCounter(int size)
    {
        this.size = size;
        counters = new Counter[size];
        for (int i = 0; i < size; i++)
        {
            counters[i] = new Counter(i.ToString());
        }
        for (int i = 0; i < size - 1; i++)
        {
            counters[i].NextCounter = counters[i + 1];
        }
        counters[size - 1].NextCounter = counters[0];
    }

    internal void Increment()
    {
        counters[0].Increment();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[Multicounter: ");


        for (int i = size - 1; i >= 0; i--)
        {
            sb.Append(counters[i].Count);
        }
        sb.Append("]");
        return sb.ToString();
    }
}