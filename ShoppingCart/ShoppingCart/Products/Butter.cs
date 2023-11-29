using ShoppingCart.Products.Interface;

namespace ShoppingCart.Products
{
    public class Butter : IProduct
    {
        public string Name => "Butter";
        public double Cost => 0.80;
    }
}