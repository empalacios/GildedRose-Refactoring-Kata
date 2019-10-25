using System.Collections.Generic;
using csharp.Decrease;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            ProductDecreaseFactory factory = new ProductDecreaseFactory();

            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                ProductDecrease decrease;

                decrease = factory.createProductDecrease(item);
                decrease.UpdateQuality();
                decrease.UpdateSellIn();
            }
        }
    }
}
