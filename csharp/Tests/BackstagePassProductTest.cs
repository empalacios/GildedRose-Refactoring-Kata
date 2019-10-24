using NUnit.Framework;
using System.Collections.Generic;

namespace csharp.Tests
{
    [TestFixture]
    public class BackstagePassProductTest
    {
        [Test]
        public void testBackstagePassIncreaseQuality()
        {
            Item testItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = 17 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(19, testItem.SellIn);
            Assert.AreEqual(18, testItem.Quality);
        }

        [Test]
        public void testBackStageIncreaseQualityWhen10DaysLeft()
        {
            Item testItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 17 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(9, testItem.SellIn);
            Assert.AreEqual(19, testItem.Quality);
        }

        [Test]
        public void testBackStageIncreaseQualityWhen5DaysLeft()
        {
            Item testItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 17 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(4, testItem.SellIn);
            Assert.AreEqual(20, testItem.Quality);
        }

        [Test]
        public void testBackstagePassConcertDatePassedDecrease()
        {
            Item testItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 23 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(-1, testItem.SellIn);
            Assert.AreEqual(Constants.MINIMUM_QUALITY, testItem.Quality);
        }

        [Test]
        public void testBackstagePassNormalIncreaseQualityIsLessOrEqualToMaximumQuality()
        {
            Item testItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 20, Quality = Constants.MAXIMUM_QUALITY };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(19, testItem.SellIn);
            Assert.AreEqual(Constants.MAXIMUM_QUALITY, testItem.Quality);
        }

        [Test]
        public void testBackStageTwoPointsIncreaseQualityIsLessOrEqualToMaximumQuailty()
        {
            Item testItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(9, testItem.SellIn);
            Assert.AreEqual(Constants.MAXIMUM_QUALITY, testItem.Quality);
        }

        [Test]
        public void testBackStageThreePointsIncreaseQualityIsLessOrEqualToMaximumQuality()
        {
            Item testItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 48 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(4, testItem.SellIn);
            Assert.AreEqual(Constants.MAXIMUM_QUALITY, testItem.Quality);
        }
    }
}
