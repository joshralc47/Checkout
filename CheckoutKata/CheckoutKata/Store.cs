using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata
{
    public class Store : IStore
    {
        private readonly Dictionary<string, Item> items = new Dictionary<string, Item>();

        public Store()
        {
            AddItem(new Item() { SKU = "A99", Price = 50, SpecialOffer = new MultiBuyOffer(3, 130) });
            AddItem(new Item() { SKU = "B15", Price = 30, SpecialOffer = new MultiBuyOffer(2, 45) });
            AddItem(new Item() { SKU = "C40", Price = 60 });
            AddItem(new Item() { SKU = "T34", Price = 99 });
        }

        public Item GetItem(string sku)
        {
            try
            {
                return items[sku];
            }
            catch
            {
                throw new NullReferenceException("Item not found");
            }
        }

        private void AddItem(Item item)
        {
            items.Add(item.SKU, item);
        }
    }
}
