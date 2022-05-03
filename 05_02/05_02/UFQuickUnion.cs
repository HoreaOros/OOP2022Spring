using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02
{
    internal class UFQuickUnion: UF
    {
        public UFQuickUnion(int n): base(n)
        {

        }
        public override void union(int p, int q)
        {
            int pRoot = find(p);
            int qRoot = find(q);

            if (pRoot != qRoot)
            {
                id[pRoot] = qRoot;
                componentNo--; // numarul de componente scade cu 1
            }

        }
        public override int find(int p)
        {
            while (p != id[p])
                p = id[p];

            return p;
        }
    }
}
