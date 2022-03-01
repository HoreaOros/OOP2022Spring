// See https://aka.ms/new-console-template for more information
internal class HorizontalBar
{
    private int length;

    public HorizontalBar(int length)
    {
        this.length = length;
        for (int i = 0; i < length; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
    }
}