namespace Bars
{
    class ClosedFrame
    {
        public uint length { get; set; }
        public uint height { get; set; }
        public ClosedFrame(uint length, uint height)
        {
            this.length = length;
            this.height = height;
            HorizontalBar hb = new(length);
            for (int i = 1; i < height ; i++)
            {
                DelimitedSpace ds = new(length);
            }
            hb = new(length);
        }
    }
}