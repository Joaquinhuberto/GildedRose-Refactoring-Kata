using System.Collections.Generic;

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
            for (var i = 0; i < Items.Count; i++)
            {
                switch (Items[i].Name)
                { 
                    case "Aged Brie":
                        {
                            if (Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                            if (Items[i].Quality < 50 && Items[i].SellIn == 0)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                            }
                            Items[i].SellIn = Items[i].SellIn - 1;
                        }
                        break;

                    case "Backstage passes to a TAFKAL80ETC concert":
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                            if (Items[i].SellIn < 11 && Items[i].Quality < 50)
                            {
                                Items[i].Quality = Items[i].Quality + 1;
                                if (Items[i].SellIn < 6 && Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                        if (Items[i].SellIn == 0)
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                        Items[i].SellIn = Items[i].SellIn - 1;
                        break;

                    case "Sulfuras, Hand of Ragnaros":
                        Items[i].Quality = 80;
                        break;

                    case "Conjured":
                        Items[i].Quality = Items[i].Quality - 2;
                        Items[i].SellIn = Items[i].SellIn - 1;
                        break;

                    default:
                        Items[i].Quality = Items[i].Quality - 1; 
                        if (Items[i].SellIn == 0)
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                        Items[i].SellIn = Items[i].SellIn - 1;
                        break;
                }
                if (Items[i].Quality < 0)
                {
                    Items[i].Quality = 0;
                }
            }
        }
    }
}
