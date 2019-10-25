namespace csharp.Decrease
{
    public class AgedBrieProductDecrease : ProductDecrease
    {
        public AgedBrieProductDecrease(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            int increaseStep = 1;
            int newQuality;

            if (Item.SellIn <= 0)
            {
                increaseStep = 2;
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
