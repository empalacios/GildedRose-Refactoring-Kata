using System;
namespace csharp.Decrease
{
    public class ConjuredProductDecrease : ProductDecrease
    {
        public ConjuredProductDecrease(Item item) : base(item)
        {
        }

        public override int ComputeDecrease()
        {
            if (Item.SellIn <= 0)
            {
                return 4;
            }
            return 2;
        }

        public override void UpdateSellIn()
        {
            Item.SellIn--;
        }
    }
}
