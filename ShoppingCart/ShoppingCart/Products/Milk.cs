using ShoppingCart.Products.Interface;

namespace ShoppingCart.Products
{
    public class Milk : IProduct
    {
        public string Name => "Milk";
        public double Cost => 1.15;
    }
}