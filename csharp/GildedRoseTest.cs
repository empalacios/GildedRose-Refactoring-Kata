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
        public void testSellDatePassedDecrease()
        {
            Item testItem = new Item { Name = "foo", SellIn = 0, Quality = 15 };
            IList<Item> Items = new List<Item> { testItem };
            GildedRose app = new GildedRose(Items);

            app.UpdateQuality();
            Assert.AreEqual(-1, testItem.SellIn);
            Assert.AreEqual(13, testItem.Quality);
        }
    }
}
