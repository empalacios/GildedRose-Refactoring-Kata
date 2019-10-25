using System;
namespace csharp
{
    public class NormalProductDecrease : ProductDecrease
    {
        public NormalProductDecrease(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            int decreaseStep = 1;
            int newQuality;

            if (Item.SellIn <= 0)
            {
                decreaseStep = 2;
            }
            newQuality = Item.Quality - decreaseStep;
            if (newQuality < Constants.MINIMUM_QUALITY)
            {
                Item.Quality = Constants.MINIMUM_QUALITY;
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
