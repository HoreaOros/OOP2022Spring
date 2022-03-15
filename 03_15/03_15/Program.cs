// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

MyStack s = new MyStack();



// PUSH
Console.WriteLine(s.IsEmpty ? "Stiva nu contine nici un element" : "In stiva sunt elemente");
s.Push(1);
Console.WriteLine(s.IsEmpty ? "Stiva nu contine nici un element" : "In stiva sunt elemente");

Console.WriteLine($"Capacitatea stivei este: {s.Capacity}");
Console.WriteLine($"Numarul de elemente din stiva este: {s.Count}");


Random rnd = new Random();
for (int i = 0; i < 42; i++)
{
    s.Push(rnd.Next(100));
}

Console.WriteLine($"Capacitatea stivei este: {s.Capacity}");
Console.WriteLine($"Numarul de elemente din stiva este: {s.Count}");


// POP
Console.WriteLine($"Dumping stack:");
while (!s.IsEmpty)
{
    Console.Write($"{s.Pop()} ");
}
Console.WriteLine();

try
{
    s.Pop();
}
catch (StackEmptyException ex)
{
    Console.WriteLine(ex.Message);
}

// PEEK
s.Push(42);
Console.WriteLine($"Numarul de elemente din stiva este: {s.Count}");
Console.WriteLine($"Elementul din varful stivei este {s.Peek()}");
Console.WriteLine($"Numarul de elemente din stiva este: {s.Count}");

//Stack<string> ss = new Stack<string>();

//ss.Push("abc");
//ss.Push("def");
//ss.Push("ghi");


//while (ss.Count > 0)
//{
//    Console.WriteLine(ss.Pop());
//}



MyStack<string> myStack = new MyStack<string>();
myStack.Push("abc");
myStack.Push("def");
myStack.Push("ghi");


while (myStack.Count > 0)
{
    Console.WriteLine(myStack.Pop());
}


