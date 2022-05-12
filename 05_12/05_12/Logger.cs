// 1.Basic queue implementation
public class Logger
{
    public static readonly Logger Instance = new Logger();
    private Logger() { }
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}