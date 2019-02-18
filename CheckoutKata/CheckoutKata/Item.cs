using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata
{
    public class Item
    {
        public string SKU { get; set; }

        public int Price { get; set; }

        public ISpecialOffer SpecialOffer {get; set; }
    }
}
