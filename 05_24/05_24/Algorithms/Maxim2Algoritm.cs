

//a = new PrimaCifraMinimaAlgoritm();
//a.Initiate();

class Maxim2Algoritm : Algoritm
{
    int x, y;
    int n;
    int[] data;
    protected override void Compute()
    {
        x = y = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= x)
            {
                y = x;
                x = data[i];
            }
            else if (data[i] > y)
            {
                y = data[i];
            }
        }
    }

    protected override void ReadInput()
    {
        n = int.Parse(Console.ReadLine());
        data = new int[n];
        for(int i = 0; i < n; i++)
            data[i] = int.Parse(Console.ReadLine());
    }

    protected override void WriteOutput()
    {
        Console.WriteLine("{0} {1}", x, y);
    }
}
