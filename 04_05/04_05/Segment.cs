using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_05
{
    public class Segment
    {
        public int Start { get; set; }
        public int End { get; set; }

        public int Length => End - Start;

        public Segment(int start, int end)
        {
            if (start > end)
            {
                (start, end) = (end, start);
            }
            Start = start;
            End = end;
        }

        public Segment? Intersect(Segment other)
        {
            if (End < other.Start) return null;
            if (Start > other.End) return null;

            int maxStart = Math.Max(Start, other.Start);
            int minEnd = Math.Min(End, other.End);

            return new Segment(maxStart, minEnd);
        }
    }
}
