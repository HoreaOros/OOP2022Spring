

//a = new PrimaCifraMinimaAlgoritm();
//a.Initiate();

class PrimaCifraMinimaAlgoritm : Algoritm
{
    int n;
    int[] data;
    int result;
    protected override void Compute()
    {
        result = data[0];
        for (int i = 1; i < n; i++)
        {
            if (GetFirstDigit(result) > GetFirstDigit(data[i]))
            {
                result = data[i];
            }
            else if(GetFirstDigit(result) == GetFirstDigit(data[i]))
                if (data[i] > result)
                {
                    result = data[i];
                }
        }
    }
    private int GetFirstDigit(int n)
    {
        while (n > 9)
        {
            n = n / 10;
        }
        return n;
    }
    protected override void ReadInput()
    {
        n = int.Parse(Console.ReadLine());
        data = new int[n];
        for (int i = 0; i < n; i++)
        {
            data[i] = int.Parse(Console.ReadLine());
        }
    }

    protected override void WriteOutput()
    {
        Console.WriteLine(result);
    }
}