using System;

namespace CheckoutKata
{
    public class MultiBuyOffer : ISpecialOffer
    {
        private readonly int numberOfItems;
        private readonly int offerPrice;

        public MultiBuyOffer(int numberOfItems, int offerPrice)
        {
            this.numberOfItems = numberOfItems;
            this.offerPrice = offerPrice;
        }

        public int Discount(int itemCount, int itemPrice)
        {
            var result = Math.DivRem(itemCount, numberOfItems, out int remainder);

            return (remainder * itemPrice) + (result * offerPrice);
        } 
    }
}
