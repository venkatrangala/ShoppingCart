using ShoppingCart.Products;
using ShoppingCart.Products.Interface;

namespace ShoppingCart.DiscountOffers.Interface
{
    public interface IDiscount
    {
        double ApplyDiscount(Dictionary<IProduct, int> products);
    }
}