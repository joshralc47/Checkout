using System.Collections.Generic;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly Dictionary<Item, int> basket = new Dictionary<Item, int>();

        private readonly IStore store;
        public Checkout(IStore store)
        {
            this.store = store;
        }

        public void Scan(string sku)
        {
            var item = store.GetItem(sku);

            if(basket.ContainsKey(item))
            {
                basket[item] += 1;
            } else
            {
                basket.Add(item, 1);
            }
        }

        public int Total()
        {
            int total = 0;

            foreach(var item in basket)
            {
                if(item.Key.SpecialOffer != null)
                {
                    total += item.Key.SpecialOffer.Discount(item.Value, item.Key.Price);
                }
                else
                {
                    total += item.Key.Price * item.Value;
                }
            }

            return total;
        }
    }
}
