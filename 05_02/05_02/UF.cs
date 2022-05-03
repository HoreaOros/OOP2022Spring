using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02
{
    internal abstract class UF
    {
        protected int[] id;
        protected int componentNo;
        /// <summary>
        /// Initializare
        /// </summary>
        /// <param name="n"></param>
        public UF(int n)
        {
            id = new int[n];
            componentNo = n;
            for (int i = 0; i < n; i++)
                id[i] = i;
        }
        /// <summary>
        /// Determina daca p si q sunt conectate
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public virtual bool connected(int p, int q)
        {
            return find(p) == find(q);
        }
        /// <summary>
        /// Determina componenta in care se afla p
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public abstract int find(int p);
        /// <summary>
        /// Stabileste o conexiune intre p si q
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public abstract void union(int p, int q);

        /// <summary>
        /// Determina numarul de componente conexe
        /// </summary>
        /// <returns></returns>
        public int count()
        {
            return componentNo;
        }
    }
}
