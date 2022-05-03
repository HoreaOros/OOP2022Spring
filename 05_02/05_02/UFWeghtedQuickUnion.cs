using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02
{
    internal class UFWeightedQuickUnion : UFQuickUnion
    {
        private int[] sz;
        public UFWeightedQuickUnion(int n) : base(n)
        {
            sz = new int[n];
            for (int i = 0; i < n; i++)
                sz[i] = 1;
        }
        public override void union(int p, int q)
        {
            int pRoot = find(p);
            int qRoot = find(q);

            if (pRoot != qRoot)
            {
                if (sz[pRoot] < sz[qRoot])
                {
                    id[pRoot] = qRoot;
                    sz[qRoot] += sz[pRoot];
                }
                else
                {
                    id[qRoot] = pRoot;
                    sz[pRoot] += sz[qRoot];
                }

                componentNo--; // numarul de componente scade cu 1
            }
        }
        

    }
}
