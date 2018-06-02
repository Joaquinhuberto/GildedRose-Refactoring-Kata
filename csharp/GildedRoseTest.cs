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
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void agedBrie()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 47 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(48, Items[0].Quality);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }

        [Test]
        public void sulfuras()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(1, Items[0].SellIn);
            Assert.AreEqual(80, Items[0].Quality);
        }

        [Test]
        public void backstagePasses()
        {
            IList<Item> Items = new List<Item> {
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 11,
                    Quality = 2
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 2
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 2
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 0,
                    Quality = 5
                }
            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3, Items[0].Quality);
            Assert.AreEqual(4, Items[1].Quality);
            Assert.AreEqual(5, Items[2].Quality);
            Assert.AreEqual(0, Items[3].Quality);
        }
        
        [Test]
        public void conjured()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured", SellIn = 5, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3, Items[0].Quality);
        }
    }
}
