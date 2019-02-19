using System;

namespace CheckoutKata
{
    class Program
    {
        static void Main(string[] args)
        {
            ICheckout checkout = new Checkout(new Store());

            var input = "";
            Console.WriteLine("Welcome to the checkout please scan your item");

            while(input != "exit")
            {
                input = Console.ReadLine();
                checkout.Scan(input);

                Console.WriteLine($"Shopping basket is now {checkout.Total()}");
                Console.WriteLine("Scan next item");
            }

            
        }
    }
}
