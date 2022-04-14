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
            Counter c = new Counter();
            c.Increment();
            int n = 10;
            while(n > 0)
            {
                c.Increment();
                n--;
            }
                

        }
    }
}
