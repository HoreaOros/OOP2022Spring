using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbInfo_546
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] data = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(data[i]);
            for (int i = 0; i < n; i++)
            {
                if (v[i] % v[n - 1] == 0)
                    Console.Write("{0} ", v[i]);
            }
        }
    }
}