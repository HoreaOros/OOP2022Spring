using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04_19
{
    class Transaction : IComparable<Transaction>
    {
        private readonly string nume;
        private readonly Date data;
        private readonly double suma;

        public static SumaOrder SUMA_ORDER = new SumaOrder();

        public Transaction(string nume, Date data, double suma)
        {
            this.nume = nume;
            this.data = data;
            this.suma = suma;
        }
        public Transaction(string transaction)
        {
            string[] tokens = transaction.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            nume = tokens[0];
            data = new Date(tokens[1]);
            suma = double.Parse(tokens[2], CultureInfo.InvariantCulture);
        }
        public string Nume
        {
            get
            {
                return nume;
            }

        }
        public Date Data
        {
            get
            {
                return data;
            }
        }
        public double Suma
        {
            get
            {
                return suma;
            }
        }
        public override string ToString()
        {
            return string.Format("{0,-20} {1,10} {2,10:F2}", nume, data, suma);
        }




        public int CompareTo(Transaction? other)
        {
            if (this.suma < other.suma)
                return -1;
            else if (this.suma > other.suma)
                return 1;
            else
                return 0;
        }
        public override bool Equals(object? x)
        {
            if (x == this)
                return true;

            if (x == null)
                return false;

            if (x.GetType() != this.GetType())
                return false;

            Transaction that = (Transaction)x;

            return (this.suma == that.suma) && (this.nume.Equals(that.nume)) && (this.data.Equals(that.data));
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = 31 * hash + nume.GetHashCode();
            hash = 31 * hash + data.GetHashCode();
            hash = 31 * hash + ((Double)suma).GetHashCode(); ;
            return hash;
        }
        public class NumeOrder : IComparer<Transaction>
        {
            public int Compare(Transaction? x, Transaction? y)
            {
                return x.nume.CompareTo(y.nume);
            }
        }
        public class DataOrder : IComparer<Transaction>
        {
            public int Compare(Transaction? x, Transaction? y)
            {
                return x.data.CompareTo(y.data);
            }
        }
        public class SumaOrder : IComparer<Transaction>
        {
            public int Compare(Transaction? x, Transaction? y)
            {
                return x.suma.CompareTo(y.suma);
            }
        }
        
    }
}
