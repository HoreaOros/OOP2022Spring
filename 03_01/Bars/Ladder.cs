// See https://aka.ms/new-console-template for more information
internal class Ladder
{
    private Frame f1, f2;
    private VerticalBar v;

    public Ladder(int length, int height1, int height2)
    {
        this.f1 = new Frame(length, height1);
        this.v = new VerticalBar(height2);
        this.f2 = new Frame(length, height1);
    }
}