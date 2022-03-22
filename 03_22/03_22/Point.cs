using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_22
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        /// <summary>
        /// Constructor implicit
        /// </summary>
        public Point(): this (0, 0)
        {
            
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Am creat un obiect de tip Point ({X}, {Y})");
        }

        public Point(int x) : this(x, 0)
        {
            
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
