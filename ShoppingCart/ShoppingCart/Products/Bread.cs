using ShoppingCart.Products.Interface;

namespace ShoppingCart.Products
{
    public class Bread : IProduct
    {
        public string Name => "Bread";
        public double Cost => 1.00;
    }
}