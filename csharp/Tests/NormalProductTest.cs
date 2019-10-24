using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class NormalProductTest
    {
        [Test]
        public void testDecrease()
        {
            Item testItem = new Item { Name = "foo", SellIn = 30, Quality = 15 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(29, testItem.SellIn);
            Assert.AreEqual(14, testItem.Quality);
        }

        [Test]
        public void testDecreaseNonNegativeQuality()
        {
            Item testItem = new Item { Name = "foo", SellIn = 20, Quality = Constants.MINIMUM_QUALITY };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(19, testItem.SellIn);
            Assert.AreEqual(Constants.MINIMUM_QUALITY, testItem.Quality);
        }

        [Test]
        public void testSellDatePassedDecrease()
        {
            Item testItem = new Item { Name = "foo", SellIn = 0, Quality = 15 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(-1, testItem.SellIn);
            Assert.AreEqual(13, testItem.Quality);
        }

        [Test]
        public void testSellDatePassedDecreaseNonNegativeQuality()
        {
            Item testItem = new Item { Name = "foo", SellIn = 0, Quality = 1 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(-1, testItem.SellIn);
            Assert.AreEqual(Constants.MINIMUM_QUALITY, testItem.Quality);
        }
    }
}
