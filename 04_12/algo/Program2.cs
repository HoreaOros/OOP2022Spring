using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int n;
            string line;

            line = Console.ReadLine();
            List<Cifra> cifre = new List<Cifra>();
            foreach (var item in line)
            {
                cifre.Add(new Cifra(item));
            }
            Console.WriteLine(cifre.Sum(item => item.Value)); 
            
        }
    }

    internal class Cifra
    {
        private int value;
        public int Value
        {
            get
            {
                return value;
            }
        }
        
        public Cifra(char item)
        {
            if (char.IsDigit(item))
            {
                value = item - '0';
            }
            else
                throw new ArgumentException();
        }
    }
}
