// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// clasa - obiect
// tip de date - variabila de acel tip

World w1 = new World();
w1.SayHello();


World w2 = new World();
w2.SayHello();


if (w1 == w2) 
{
    Console.WriteLine("Same worlds");
}
else
{
    Console.WriteLine("Different worlds");
}

Console.WriteLine($"id of w1: {w1.Id}");
Console.WriteLine($"id of w2: {w2.Id}");

Console.WriteLine(w1);
Console.WriteLine(w2);

