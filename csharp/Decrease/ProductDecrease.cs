namespace csharp
{
    public abstract class ProductDecrease
    {
        public ProductDecrease(Item item)
        {
            Item = item;
        }

        public Item Item { get; set; }

        public abstract int ComputeDecrease();

        public virtual void UpdateQuality()
        {
            int decreaseStep = ComputeDecrease();
            int newQuality = Item.Quality - decreaseStep;

            if (newQuality < Constants.MINIMUM_QUALITY)
            {
                Item.Quality = Constants.MINIMUM_QUALITY;
            } else if (newQuality > Constants.MAXIMUM_QUALITY)
            {
                Item.Quality = Constants.MAXIMUM_QUALITY;
            }
            else
            {
                Item.Quality = newQuality;
            }
        }

        public abstract void UpdateSellIn();
    }
}
