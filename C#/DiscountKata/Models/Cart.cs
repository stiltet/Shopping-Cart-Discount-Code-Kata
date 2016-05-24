/**
 * Created by Stellan Lindell 25/2 2016.
**/

using System.Collections.Generic;

namespace DiscountKata.Models
{
    public class Cart
    {
        public List<CartItem> CartItems; 

        public void Add(CartItem cartItem)
        {
            
        }

        public int TotalPrice()
        {
            return 100;
        }
    }
}
