// See https://aka.ms/new-console-template for more information
internal class VerticalBar
{
    private uint height;

    public VerticalBar(uint height)
    {
        this.height = height;
        for (uint i = 0; i < height; i++)
        {
            Console.WriteLine('|');
        }
    }
}