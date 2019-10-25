namespace csharp.Decrease
{
    public class AgedBrieProductDecrease : ProductDecrease
    {
        public AgedBrieProductDecrease(Item item) : base(item)
        {
        }

        public override int ComputeDecrease()
        {
            if (Item.SellIn <= 0)
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
