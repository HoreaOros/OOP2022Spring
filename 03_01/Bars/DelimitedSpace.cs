namespace Bars
{
    class DelimitedSpace
    {
        public uint length { get; set; }
        public DelimitedSpace(uint length)
        {
            this.length = length;
            VerticalBar vb = new(1);
            for (int i = 1; i <= length-2; i++)
            {
                Console.Write("\s");
            }
            vb = new(1);//pentru ca bara este desenata numai la instantierea constructorului, trebuie sa inlocuiesc variabila cu o instanta noua
            Console.WriteLine();
        }
    }
}
