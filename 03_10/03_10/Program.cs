// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Console.WriteLine(d1);
//DateTime d2 = d1.AddYears(-22);
//Console.WriteLine(d2);

// TODO: studiati tipurile de date DateTime si DateTimeOffset.
using _03_10;

DateTime dt = DateTime.Now;

dt.ToString("R");

MyDate d1 = new MyDate(2022, 3, 10);
Console.WriteLine(d1);

MyDate d2 = new MyDate(2030, 3, 10);
Console.WriteLine(d2);


if (d2.LessThan(d1))
{
    Console.WriteLine($"{d1.ToString("yyyy:MMM:dd")} less than {d2}");
}
else
{
    Console.WriteLine($"{d2.ToString("yyyy:MM:dd")} is not less than {d1}");
}

Console.WriteLine($"Numărul de zile dintre {d1} si {d2} este {d1.DaysTo(d2)}");