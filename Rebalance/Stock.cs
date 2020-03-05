namespace Rebalance
{
    public class Stock
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
        public int Position { get; set; }
        public float Percent { get; set; }
        public int NewPosition { get; set; }
        public int Buy { get; set; }
        public int Sell { get; set; }
    }
}