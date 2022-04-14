using System;
using System.Text;
namespace _04_14
{
    internal class MultiCounter
    {
        int size;

        ChainedModulusCounter[] cmc;

        public string Value 
        { 
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = size - 1; i >= 0; i--)
                {
                    sb.Append(cmc[i].Count);
                }
                return sb.ToString();
            }
        }
        public MultiCounter(int size, int modulus)
        {
            this.size = size;

            cmc = new ChainedModulusCounter[size];
            cmc[size - 1] = new ChainedModulusCounter(modulus, "", null);
            for (int i = size - 2; i >= 0; i--)
                cmc[i] = new ChainedModulusCounter(modulus, "", cmc[i + 1]);

            

        }

        public void Increment()
        {
            cmc[0].Increment();
        }
    }
}