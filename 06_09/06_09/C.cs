// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

internal class C
{
    int id;
    public C()
    {
        id = 0;
        Console.WriteLine("Se ruleaza constructorului C()");
    }
    public C(int id)
    {
        this.id = id;
        Console.WriteLine("Se ruleaza constructorului C(int)");
    }

    public  virtual void f()
    {
        Console.WriteLine("S-a apelat functia C.f()");
    }
}