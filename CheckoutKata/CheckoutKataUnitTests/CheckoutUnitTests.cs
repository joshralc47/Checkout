using CheckoutKata;
using System;
using Xunit;

namespace CheckoutKataUnitTests
{
    public class CheckoutUnitTests
    {
        private readonly ICheckout checkout;

        public CheckoutUnitTests()
        {
            checkout = new Checkout(new Store());
        }

        [Fact]
        public void Total_ScanNothing_Return0()
        {
            var expected = 0;

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanA99_Return50()
        {
            var expected = 50;

            checkout.Scan("A99");

            var result = checkout.Total();

            Assert.Equal(expected, result);

        }

        [Fact]
        public void Total_ScanB15_Return30()
        {
            var expected = 30;

            checkout.Scan("B15");

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanC40_Return60()
        {
            var expected = 60;

            checkout.Scan("C40");

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanT34_Return99()
        {
            var expected = 99;

            checkout.Scan("T34");

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanT34AndA99_Return149()
        {
            var expected = 149;

            checkout.Scan("T34");
            checkout.Scan("A99");

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanThreeA99_Return130()
        {
            var expected = 130;

            checkout.Scan("A99");
            checkout.Scan("A99");
            checkout.Scan("A99");

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanTwoB15_Return45()
        {
            var expected = 45;

            checkout.Scan("B15");
            checkout.Scan("B15");

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanFourB15_Return90()
        {
            var expected = 90;

            checkout.Scan("B15");
            checkout.Scan("B15");
            checkout.Scan("B15");
            checkout.Scan("B15");

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanSixA99_Return260()
        {
            var expected = 260;

            checkout.Scan("A99");
            checkout.Scan("A99");
            checkout.Scan("A99");
            checkout.Scan("A99");
            checkout.Scan("A99");
            checkout.Scan("A99");

            var result = checkout.Total();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Total_ScanUnknownItem_ThrowException()
        {
            Assert.Throws<NullReferenceException>(() => checkout.Scan("Chicken"));
        }

    }
}
