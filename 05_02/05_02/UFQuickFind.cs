using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_02
{
    internal class UFQuickFind: UF
    {
        public UFQuickFind(int n): base(n)
        {

        }
        public override int find(int p)
        {
            return id[p];
        }
        public override void union(int p, int q)
        {
            int pId = find(p);
            int qId = find(q);

            if (pId == qId)
                return;

            for (int i = 0; i < id.Length; i++)
                if (id[i] == pId)
                    id[i] = qId;

            componentNo--;
        }
    }
}
