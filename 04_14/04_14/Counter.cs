namespace _04_14
{
    internal class Counter
    {
        string id;
        int count;
        public Counter(): this("")
        {
            
        }
        public Counter(string id)
        {
            this.id = id;
            count = 0;
        }
    }
}