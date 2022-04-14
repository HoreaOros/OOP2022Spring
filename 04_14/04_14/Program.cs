using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter("");

            c.Increment();
            int n = 10;
            while(n > 0)
            {
                c.Increment();
                n--;
            }

            Console.WriteLine(c.Count);

            Counter heads = new Counter("heads");
            Counter tails = new Counter("tails");

            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                switch (rnd.Next(2))
                {
                    case 0:
                        heads.Increment();
                        break;
                    case 1:
                        tails.Increment();
                        break;
                }
            }
            Console.WriteLine($"Heads: {heads.Count}, Tails: {tails.Count}");

            Console.WriteLine(heads);


            ModulusCounter mc = new ModulusCounter(10, "zece");

            for (int i = 0; i < 100; i++)
            {
                mc.Increment();
                Console.WriteLine(mc);
            }
        }
    }
}
