namespace _04_14
{
    internal class ChainedModulusCounter : ModulusCounter
    {
        ChainedModulusCounter next;
        public ChainedModulusCounter(int modulus, string id, 
            ChainedModulusCounter nextCounter) : base(modulus, id)
        {
            this.next = nextCounter;
        }
        public override void Increment()
        {
            base.Increment();
            if (Count == 0)
            {
                next.Increment();
            }
        }
    }
}