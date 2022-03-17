
Console.WriteLine("Hello, World!");

MyStack s = new MyStack();

Random rnd = new Random();

for (int i = 0; i < 100; i++)
{
    s.Push(rnd.Next(100));
}

Console.WriteLine($"Numarul de elemente din stiva este: {s.Count}");

int sum = 0;
while (s.Count > 0)
{
    sum += s.Pop();
}
Console.WriteLine($"Numarul de elemente din stiva este: {s.Count}");



s.Push(1);
Console.WriteLine($"Elementul din varful stivei este: {s.Peek()}");