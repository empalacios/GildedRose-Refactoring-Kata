namespace csharp.Decrease
{
    public class BackstagePassProductDecrease:ProductDecrease
    {
        public BackstagePassProductDecrease(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            int increaseStep = 1;
            int newQuality;

            if (Item.SellIn == 0)
            {
                Item.Quality = 0;
                return;
            }
            if (Item.SellIn <= 10)
            {
                increaseStep = 2;
            }
            if (Item.SellIn <= 5)
            {
                increaseStep = 3;
            }
            newQuality = Item.Quality + increaseStep;
            if (newQuality > Constants.MAXIMUM_QUALITY)
            {
                Item.Quality = Constants.MAXIMUM_QUALITY;
            }
            else
            {
                Item.Quality = newQuality;
            }
        }

        public override void UpdateSellIn()
        {
            Item.SellIn--;
        }
    }
}
