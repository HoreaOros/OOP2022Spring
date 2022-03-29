namespace _03_29
{
    public static class Util
    {
        public static uint Gcd(uint a, uint b)
        {
            uint r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }
}