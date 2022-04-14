using System;

namespace _04_14
{
    public class Counter
    {
        #region Fields
        protected string id;
        protected int count;
        #endregion

        #region Properties
        //public int Count => count;
        public int Count 
        {
            get
            {
                return count;
            }
        }
        #endregion

        #region Constructors
        public Counter(): this("")
        {
            
        }
        public Counter(string id)
        {
            this.id = id;
            count = 0;
        }
        #endregion

        #region Methods
        public virtual void Increment()
        {
            count++;
        }
        public override string ToString()
        {
            return $"[Counter: Id = <{id}>, Value = {count}]";
        }
        #endregion
    }
}