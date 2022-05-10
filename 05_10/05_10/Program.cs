// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using _05_10;

//MyQueue q1 = new MyQueue();
//q1.Enqueue(1);
//q1.Enqueue(2);
//q1.Enqueue(3);

//Console.WriteLine($"Numarul de elemente din coada este: {q1.Count}");

//while (!q1.Empty)
//{
//    Console.WriteLine(q1.Dequeue());
//}


Random rnd = new Random();
//MyGenericQueue<int> q2 = new MyGenericQueue<int>();

//for (int i = 1; i <= 100; i++)
//{
//    int op = rnd.Next(4);
//    int val;
//    if (op <= 2)
//    {
//        val = rnd.Next(1000);
//        q2.Enqueue(val);
//        Console.WriteLine($"enqueue - {val}");
//    }
//    else
//        Console.WriteLine($"deque - {q2.Dequeue()}");
//}


MyGenericListQueue<int> q3 = new MyGenericListQueue<int>();
for (int i = 1; i <= 100; i++)
{
    int op = rnd.Next(4);
    int val;
    if (op <= 2)
    {
        val = rnd.Next(1000);
        q3.Enqueue(val);
        Console.WriteLine($"enqueue - {val}");
    }
    else
        Console.WriteLine($"deque - {q3.Dequeue()}");
}






