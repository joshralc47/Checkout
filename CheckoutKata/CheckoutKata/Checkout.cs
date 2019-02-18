using System;
using System.Collections.Generic;
using System.Text;

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

        public void Scan(string sKU)
        {
            var item = store.GetItem(sKU);

            if(basket.ContainsKey(item))
            {
                basket[item] = +1;
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
                total += item.Key.Price * item.Value;
            }

            return total;
        }
    }
}
