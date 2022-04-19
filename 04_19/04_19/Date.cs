using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_19
{
    /// <summary>
    /// Data calendaristica
    /// </summary>
    public class Date : IComparable<Date>
    {
        private int zi, luna, an;
        public Date(int zi, int luna, int an)
        {
            // TODO validare (zi, luna, an)
            this.zi = zi;
            this.luna = luna;
            this.an = an;
        }
        public Date(string data)
        {
            string[] tokens = data.Split(new char[] { '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
            zi = int.Parse(tokens[0]);
            luna = int.Parse(tokens[1]);
            an = int.Parse(tokens[2]);
        }
        public int Zi
        {
            get
            {
                return zi;
            }
        }
        public int Luna
        {
            get
            {
                return luna;
            }
        }
        public int An
        {
            get
            {
                return an;
            }
        }
        public override string ToString()
        {
            return zi + "/" + luna + "/" + an;
        }
        public static void Main(string[] args)
        {

        }

        public int CompareTo(Date other)
        {
            if (other == null)
                return 1;
            if (this.an < other.an)
                return -1;
            else if (this.an > other.an)
                return 1;
            else if (this.luna < other.luna)
                return -1;
            else if (this.luna > other.luna)
                return 1;
            else if (this.zi < other.zi)
                return -1;
            else if (this.zi > other.zi)
                return 1;
            else
                return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            if (obj == null)
                return false;

            if (obj.GetType() != this.GetType())
                return false;

            Date that = (Date)obj;
            return (this.an == that.an && this.luna == that.luna && this.zi == that.zi);
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = 31 * hash + luna;
            hash = 31 * hash + zi;
            hash = 31 * hash + an;
            return hash;
        }
    }
}
