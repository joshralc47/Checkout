
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKata
{
    public interface IStore
    {
        Item GetItem(string sku);
    }
}
