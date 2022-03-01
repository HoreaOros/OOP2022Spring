// See https://aka.ms/new-console-template for more information
internal class HorizontalBar
{
    private uint length;

    public HorizontalBar(uint length)
    {
        this.length = length;
        for (uint i = 0; i < length; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
    }
}