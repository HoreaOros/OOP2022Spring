// See https://aka.ms/new-console-template for more information
using _05_02;
using System.IO;

StreamReader sr = new StreamReader("largeUF.txt");
string line;

int N, p, q;
line = sr.ReadLine();
N = int.Parse(line);

UFWeightedQuickUnion uf = new UFWeightedQuickUnion(N);

while (!sr.EndOfStream)
{
    line = sr.ReadLine();
    string[] tokens = line.Split(' ');
    p = int.Parse(tokens[0]);
    q = int.Parse(tokens[1]);

    if (uf.connected(p, q))
        continue;

    uf.union(p, q);
    //Console.WriteLine("{0} - {1}", p, q);
}

Console.WriteLine("{0} componente", uf.count());
