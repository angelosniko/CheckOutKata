using KataCheckout.Interface;
using System;
using System.Collections.Generic;
using Xunit;

namespace KataCheckout
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expected = 80;
            var priceList = new Dictionary<string, int> { { "A", 50 }, { "B", 30 } };
            var checkout = new Checkout(priceList);

            checkout.Scan("A");
            checkout.Scan("B");

            var actual = checkout.GetTotalPrice();

            Assert.Equal(expected, actual);



        }


        [Fact]
        public void Test2()
        {
            var expected = 95;
            var priceList = new Dictionary<string, int> { { "A", 50 }, { "B", 30 } };
            var discounts = new List<Discount> {
            new Discount{ Sku="B",Price=45,CountValue=2}

            };
            var checkout = new Checkout(priceList,discounts);

            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("B");

            var actual = checkout.GetTotalPrice();

            Assert.Equal(expected, actual);



        }

        [Fact]
        public void Test3()
        {
            var expected = 130;
            var priceList = new Dictionary<string, int> { { "A", 50 }, { "B", 30 } };
            var discounts = new List<Discount> {
            new Discount{ Sku="A",Price=130,CountValue=3}

            };
            var checkout = new Checkout(priceList, discounts);

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            var actual = checkout.GetTotalPrice();

            Assert.Equal(expected, actual);



        }

        [Fact]
        public void Test4()
        {
            var expected = 175;
            var priceList = new Dictionary<string, int> { { "A", 50 }, { "B", 30 } };
            var discounts = new List<Discount> {
            new Discount{ Sku="A",Price=130,CountValue=3},
            new Discount{ Sku="B",Price=45,CountValue=2}

            };
            var checkout = new Checkout(priceList, discounts);

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("B");


            var actual = checkout.GetTotalPrice();

            Assert.Equal(expected, actual);



        }
        [Fact]
        public void Test5()
        {
            var expected = 130;
            var priceList = new Dictionary<string, int> { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
            var discounts = new List<Discount> {
            new Discount{ Sku="A",Price=130,CountValue=3},
            new Discount{ Sku="B",Price=45,CountValue=2}

            };
            var checkout = new Checkout(priceList, discounts);

            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("D");
            checkout.Scan("B");


            var actual = checkout.GetTotalPrice();

            Assert.Equal(expected, actual);



        }


        [Fact]
        public void Test6()
        {
            var expected = 115;
            var priceList = new Dictionary<string, int> { { "A", 50 }, { "B", 30 }, { "C", 20 }, { "D", 15 } };
            var discounts = new List<Discount> {
            new Discount{ Sku="A",Price=130,CountValue=3},
            new Discount{ Sku="B",Price=45,CountValue=2}

            };
            var checkout = new Checkout(priceList, discounts);

            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("D");
            


            var actual = checkout.GetTotalPrice();

            Assert.Equal(expected, actual);



        }


        [Fact]
        public void Test7()
        {
            var expected = 160;
            var priceList = new Dictionary<string, int> { { "A", 50 }, { "B", 30 } };
            var discounts = new List<Discount> {
            new Discount{ Sku="A",Price=130,CountValue=3}

            };
            var checkout = new Checkout(priceList, discounts);

            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("B");

            var actual = checkout.GetTotalPrice();

            Assert.Equal(expected, actual);



        }








    }
}
