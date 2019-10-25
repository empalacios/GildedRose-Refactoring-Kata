using System;
namespace csharp
{
    public class NormalProductDecrease : ProductDecrease
    {
        public NormalProductDecrease(Item item) : base(item)
        {
        }

        public override int ComputeDecrease()
        {
            if (Item.SellIn <= 0)
            {
                return 2;
            }
            return 1;
        }

        public override void UpdateSellIn()
        {
            Item.SellIn--;
        }
    }
}
