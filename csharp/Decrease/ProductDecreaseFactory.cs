using System;
namespace csharp.Decrease
{
    public class ProductDecreaseFactory
    {
        public ProductDecreaseFactory()
        {
        }

        public ProductDecrease createProductDecrease(Item item) {
            switch(item.Name)
            {
                case Products.AGED_BRIE:
                    return new AgedBrieProductDecrease(item);
                case Products.BACKSTAGE_PASS:
                    return new BackstagePassProductDecrease(item);
                case Products.SULFURAS:
                    return new SulfurasProductDecrease(item);
                case Products.CONJURED:
                    return new ConjuredProductDecrease(item);
                default:
                    return new NormalProductDecrease(item);
            }
        }
    }
}
