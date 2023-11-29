using ShoppingCart.DiscountOffers.Interface;
using ShoppingCart.Products;
using ShoppingCart.Products.Interface;

namespace ShoppingCart.DiscountOffers
{
    public class MilkDiscount : IDiscount
    {
        public double ApplyDiscount(Dictionary<IProduct, int> products)
        {
            var milkProducts = products.Where(x => x.Key.Name == new Milk().Name);
            if (milkProducts != null)
            {
                int freeMilkCount = milkProducts.Count() / 4;

                return freeMilkCount * new Milk().Cost;
            }

            return 0;
        }
    }
}