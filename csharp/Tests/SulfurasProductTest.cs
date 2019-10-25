using csharp.Decrease;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class SulfurasProductTest
    {
        [Test]
        public void testSulfurasNoDecreaseInQualityAndSaleDate()
        {
            Item testItem = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 14, Quality = 27 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(14, testItem.SellIn);
            Assert.AreEqual(SulfurasProductDecrease.SULFURAS_QUALITY, testItem.Quality);
        }
    }
}
