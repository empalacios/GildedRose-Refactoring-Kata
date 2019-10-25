namespace csharp.Decrease
{
    public class BackstagePassProductDecrease:ProductDecrease
    {
        public BackstagePassProductDecrease(Item item) : base(item)
        {
        }

        public override int ComputeDecrease()
        {
            if (Item.SellIn <= 0)
            {
                return Item.Quality;
            }
            if (Item.SellIn <= 5)
            {
                return -3;
            }
            if (Item.SellIn <= 10)
            {
                return -2;
            }
            return -1;
        }

        public override void UpdateSellIn()
        {
            Item.SellIn--;
        }
    }
}
