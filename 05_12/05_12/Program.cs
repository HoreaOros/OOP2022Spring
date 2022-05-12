// 1.Basic queue implementation
/*MyQueue q1 = new MyQueue(10);
q1.Enqueue(1);
q1.Enqueue(2);
q1.Enqueue(3);

Console.WriteLine($"Numarul de elemente din coada {q1.Count}");

int val;
while (!q1.Empty)
{
    val = q1.Dequeue();
    Logger.Instance.Log($"Am scos din coada valoarea {val}");
}

*/


/*
int val;
MyQueue q2 = new MyQueue(100);
Random rnd = new Random();
int maxValue = 1000;
for (int i = 0; i < 100; i++)
{
    int op;
    op = rnd.Next(4);
    switch (op)
    {
        case 0: case 1:
        case 2:
            val = rnd.Next(maxValue + 1);
            q2.Enqueue(val);
            break;
        case 3:
            val = q2.Dequeue();
            Logger.Instance.Log($"Am scos din coada valoarea {val}");
            break;
    }
}

*/


MyQueue<int> q3 = new MyQueue<int>();
q3.Enqueue(1);
q3.Enqueue(2);
q3.Enqueue(3);

MyQueue<string> q4 = new MyQueue<string>();
q4.Enqueue("to");
q4.Enqueue("be");
q4.Enqueue("or");
q4.Enqueue("not");
q4.Enqueue("to");
q4.Enqueue("be");

string val;
while (!q4.Empty)
{
    val = q4.Dequeue();
    Logger.Instance.Log($"Am scos din coada: <{val}>");
}

