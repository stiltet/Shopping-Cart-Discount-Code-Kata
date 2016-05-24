/**
 * Created by Stellan Lindell 25/2 2016.
**/

using DiscountKata.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
Shopping cart code kata requirements:

The system shall allways chose the best possible discount for the customer.
If multiple discounts are valid shall the system allways chose the largest
discount first and there after the other in descending order.

1.	Calculate cart with items price and add a shipping cost of 50SEK.
2.	a) Free shipping when total price of all items in cart exceeds 400SEK.
	b) Free shipping when the cart contains more than 5 different items.
3.	If there are 5+ of the same item there should be a volume discount of 
	10% that's only valid on that specific item.
4.	Regular custumers gets 10% discount on the whole cart.
5.	Winter holidays sale (Mellandagsrea) 50% on all items in cart between 
	boxing day and new years eve. (Can't be combined with 3 or 4)
6.	Expired items with a stock balance of less then 10 gives 40% discount.
	(Can't be combined with 3, 4 or 5)
7.	Discount voucher gives customers 15% total cart disount on one purchase.
	(Can't be combined with 4, 5 or 6)
	
Happy coding! :) 
*/

namespace DiscountKata.Tests
{
    [TestClass]
    public class CartTests
    {
        [TestMethod]
        public void ShouldAddFreightCostWhenCartContainsOneCartItem()
        {
            var cart = new Cart();
            cart.Add(new CartItem("Vara", 50, 1));

            Assert.AreEqual(100, cart.TotalPrice(),
                string.Format("Total price should be 100SEK but are {0}SEK.", cart.TotalPrice()));
        }

        [TestMethod]
        public void ShouldAddFreightCostWhenCartContainsMultipleCartItems()
        {
            var cart = new Cart();
            cart.Add(new CartItem("Vara1", 50, 1));
            cart.Add(new CartItem("Vara2", 75, 1));
            cart.Add(new CartItem("Vara3", 25, 1));
            cart.Add(new CartItem("Vara4", 100, 1));

            Assert.AreEqual(300, cart.TotalPrice(),
                string.Format("Total price should be 300SEK but are {0}SEK.", cart.TotalPrice()));
        }
    }
}