/**
 * Created by Stellan Lindell 25/2 2016.
**/

namespace DiscountKata.Models
{
    public class CartItem
    {
        public string Title;
        public double Price;
        public int Count;

        public CartItem(string title, double price, int count)
        {
            Title = title;
            Price = price;
            Count = count;
        }
    }
}
