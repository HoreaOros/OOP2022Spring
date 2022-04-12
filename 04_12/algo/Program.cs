using System;


namespace algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(n.SumaCifre());
        }
    }
    public static class MyExtensions
    {
        public static int SumaCifre(this int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10; 
            }
            return suma; 
        }
    }
}
