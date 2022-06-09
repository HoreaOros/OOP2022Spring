// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

internal class D: C
{
    public D()
    {
        Console.WriteLine("Se ruleaza constructorului D()");
    }
    public D(int id): base(id)
    {
        Console.WriteLine("Se ruleaza constructorului D(int)");
    }

    public override void f()
    {
        Console.WriteLine("S-a apelat functia D.f()");
    }
}