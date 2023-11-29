using ShoppingCart.DiscountOffers;
using ShoppingCart.DiscountOffers.Interface;
using ShoppingCart.Products.Interface;

namespace ShoppingCart
{
    public class CustomerBasket
    {
        private readonly Dictionary<IProduct, int> _products;
        private readonly List<IDiscount> _discounts;

        public CustomerBasket()
        {
            _products = new Dictionary<IProduct, int>();
            _discounts = new List<IDiscount> { new ButterBreadDiscount(), new MilkDiscount() };
        }

        public void AddProduct(IProduct product)
        {
            if (_products.ContainsKey(product))
            {
                _products[product]++;
            }
            else
            {
                _products.Add(product, 1);
            }
        }

        public double TotalCost()
        {
            double totalCost = 0;

            // Calculate products without discounts
            foreach (var (product, quantity) in _products)
            {
                totalCost += product.Cost * quantity;
            }

            // Apply discounts
            totalCost -= CalculateDiscounts();

            return totalCost;
        }

        private double CalculateDiscounts()
        {
            return _discounts.Sum(discount => discount.ApplyDiscount(_products));
        }
    }
}