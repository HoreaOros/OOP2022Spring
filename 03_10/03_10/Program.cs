// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

DateTime d1 = DateTime.Now;

//Console.WriteLine(d1);
//DateTime d2 = d1.AddYears(-22);
//Console.WriteLine(d2);


MyDate d1 = new MyDate(2022, 3, 10);
Console.WriteLine(d1);

MyDate d2 = new MyDate(2030, 3, 10);
Console.WriteLine(d2);


if (d2.LessThan(d1))
{
    Console.WriteLine($"{d1} less than {d2}");
}
else
{
    Console.WriteLine($"{d2} is not less than {d1}");
}

Console.WriteLine($"Numărul de zile dintre {d1} si {d2} este {d1.DaysTo(d2)}");
