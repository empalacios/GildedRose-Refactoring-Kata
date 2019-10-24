using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class AgedBrieProductTest
    {
        [Test]
        public void testAgedBrieIncreaseQuality()
        {
            Item testItem = new Item { Name = "Aged Brie", SellIn = 20, Quality = 17 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(19, testItem.SellIn);
            Assert.AreEqual(18, testItem.Quality);
        }

        [Test]
        public void testAgedBrieSaleDatePassedIncreaseQuality()
        {
            Item testItem = new Item { Name = "Aged Brie", SellIn = 0, Quality = 17 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(-1, testItem.SellIn);
            Assert.AreEqual(19, testItem.Quality);
        }

        [Test]
        public void testAgedBrieNotIncreaseQualityWhenMaximumQuality()
        {
            Item testItem = new Item { Name = "Aged Brie", SellIn = 20, Quality = Constants.MAXIMUM_QUALITY };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(19, testItem.SellIn);
            Assert.AreEqual(Constants.MAXIMUM_QUALITY, testItem.Quality);
        }

        [Test]
        public void testAgedBrieNotIncreaseQualitySaleDatePassedWhenMaximumQuality()
        {
            Item testItem = new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(-1, testItem.SellIn);
            Assert.AreEqual(Constants.MAXIMUM_QUALITY, testItem.Quality);
        }
    }
}
