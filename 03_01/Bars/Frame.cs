// See https://aka.ms/new-console-template for more information
internal class Frame
{
    private HorizontalBar h1, h2;
    private VerticalBar v;

    public Frame(uint length, uint height)
    {
        h1 = new HorizontalBar(length);
        v = new VerticalBar(height);
        h2 = new HorizontalBar(length);
    }
}