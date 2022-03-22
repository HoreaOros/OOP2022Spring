
using _03_22;

Console.WriteLine("Hello, World!");

Point p1 = new Point { X = 3.0, Y = 4.0 };
Point p2 = new Point();
Point p3 = new Point(3, 4);

Console.WriteLine(p1);

Point p4 = new Point(5);

Point p5 = new Point(5.0, 6.0) { Color = Color.Verde};

Console.WriteLine(p5);

Console.WriteLine($"Distanta de la origine la punctul {p1} este {p1.GetDistanceToOrigin()}");

Point p6 = new Point(1,1);
p6.MoveBy(2,2);
Console.WriteLine(p6);




