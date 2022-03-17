
Console.WriteLine("Hello, World!");

MyStack s = new MyStack();

Random rnd = new Random();

for (int i = 0; i < 10; i++)
{
    s.Push(rnd.Next(100));
}

Console.WriteLine($"Numarul de elemente din stiva este: {s.Count}");


