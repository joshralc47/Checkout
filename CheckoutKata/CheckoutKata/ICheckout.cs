namespace CheckoutKata
{
    public interface ICheckout
    {
        void Scan(string sKu);
        int Total();
    }
}
