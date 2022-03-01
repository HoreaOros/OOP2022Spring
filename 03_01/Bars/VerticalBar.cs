// See https://aka.ms/new-console-template for more information
internal class VerticalBar
{
    private int height;

    public VerticalBar(int height)
    {
        this.height = height;
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine('|');
        }
    }
}