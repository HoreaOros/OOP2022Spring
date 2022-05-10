// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
MyQueue q1 = new MyQueue();
q1.Enqueue(1);
q1.Enqueue(2);
q1.Enqueue(3);

Console.WriteLine($"Numarul de elemente din coada este: {q1.Count}");

while (!q1.Empty)
{
    Console.WriteLine(q1.Dequeue());
}

