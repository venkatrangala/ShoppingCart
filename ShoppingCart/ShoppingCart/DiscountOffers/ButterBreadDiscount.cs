using ShoppingCart.DiscountOffers.Interface;
using ShoppingCart.Products;
using ShoppingCart.Products.Interface;

namespace ShoppingCart.DiscountOffers
{
    public class ButterBreadDiscount : IDiscount
    {
        public double ApplyDiscount(Dictionary<IProduct, int> products)
        {
            var butterProducts = products.Where(x => x.Key.Name == new Butter().Name);
            var breadProdcuts = products.Where(x => x.Key.Name == new Bread().Name);
            if (butterProducts != null && breadProdcuts != null)
            {
                int discountedBreadCount = Math.Min(butterProducts.Count() / 2, breadProdcuts.Count());
                double breadDiscount = discountedBreadCount * 0.50;

                return breadDiscount;
            }

            return 0;
        }
    }
}