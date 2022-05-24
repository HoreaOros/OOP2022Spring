


abstract class Algoritm
{
    public void Initiate()
    {
        ReadInput();
        Compute();
        WriteOutput();
    }
    abstract protected void ReadInput();
    abstract protected void Compute();
    abstract protected void WriteOutput();
}
