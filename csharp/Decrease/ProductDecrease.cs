namespace csharp
{
    public abstract class ProductDecrease
    {
        public ProductDecrease(Item item)
        {
            Item = item;
        }

        public Item Item { get; set; }

        public abstract void UpdateQuality();

        public abstract void UpdateSellIn();
    }
}
