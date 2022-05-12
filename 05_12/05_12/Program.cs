// 1.Basic queue implementation
MyQueue q1 = new MyQueue();
q1.Enqueue(1);
q1.Enqueue(2);
q1.Enqueue(3);

Console.WriteLine($"Numarul de elemente din coada {q1.Count}");

while (!q1.Empty)
{
    Console.WriteLine($"q1.Dequeue()");
}

