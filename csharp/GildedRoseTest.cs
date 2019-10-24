using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "fixme", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
        }

        [Test]
        public void testNormalDecrease()
        {
            Item testItem = new Item { Name = "foo", SellIn = 30, Quality = 15 };
            IList<Item> Items = new List<Item> { testItem  };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(29, testItem.SellIn);
            Assert.AreEqual(14, testItem.Quality);
        }

        [Test]
        public void testNormalDecreaseNonNegativeQuality()
        {
            Item testItem = new Item { Name = "foo", SellIn = 20, Quality = 0 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(19, testItem.SellIn);
            Assert.AreEqual(0, testItem.Quality);
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
            Assert.AreEqual(0, testItem.Quality);
        }

        [Test]
        public void testSulfurasNoDecreaseInQualityAndSaleDate()
        {
            Item testItem = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 14, Quality = 27 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(14, testItem.SellIn);
            Assert.AreEqual(27, testItem.Quality);
        }

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
        public void testAgedBrieNotIncreaseQualityWhenMaximumQuality()
        {
            Item testItem = new Item { Name = "Aged Brie", SellIn = 20, Quality = 50 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(19, testItem.SellIn);
            Assert.AreEqual(50, testItem.Quality);
        }

        [Test]
        public void testAgedBrieNotIncreaseQualitySaleDatePassedWhenMaximumQuality()
        {
            Item testItem = new Item { Name = "Aged Brie", SellIn = 0, Quality = 49 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(-1, testItem.SellIn);
            Assert.AreEqual(50, testItem.Quality);
        }
    }
}
