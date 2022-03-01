using System;
internal class World
{
    // metoda constructor implicit
    private Guid id; 
    public World()
    {
        id = Guid.NewGuid();
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello World of OOP! from {id}");
    }

    public override string ToString()
    {
        return string.Format("[World with id = {0}]", id);
    }

    public Guid Id
    {
        get
        {
            return id;
        }
    }
}