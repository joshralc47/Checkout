using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private readonly IStore store;
        public Checkout(IStore store)
        {
            this.store = store;
        }

        public void Scan(string sKU)
        {
            throw new NotImplementedException();
        }

        public int Total()
        {
            return 0;
        }
    }
}
