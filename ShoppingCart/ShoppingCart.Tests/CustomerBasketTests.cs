using Xunit;
using ShoppingCart.Products;

namespace ShoppingCart.Tests
{
    public class CustomerBasketTests
    {
        /// <summary>
        /// Given the basket has 1 bread, 1 butter and 1 milk when I total the basket then the total should be £2.95
        /// </summary>
        [Fact]
        
        public void Test_Basket_Scenario1()
        {
            var basket = new CustomerBasket();
            basket.AddProduct(new Bread());
            basket.AddProduct(new Butter());
            basket.AddProduct(new Milk());

            Assert.Equal(2.95, basket.TotalCost(), 2);
        }

        /// <summary>
        /// Given the basket has 2 butter and 2 bread when I total the basket then the total should be £3.10
        /// </summary>
        [Fact]
        public void Test_Basket_Scenario2()
        {
            var basket = new CustomerBasket();
            basket.AddProduct(new Butter());
            basket.AddProduct(new Butter());
            basket.AddProduct(new Bread());
            basket.AddProduct(new Bread());

            Assert.Equal(3.10, basket.TotalCost(), 2);
        }

        /// <summary>
        /// Given the basket has 4 milk when I total the basket then the total should be £3.45
        /// </summary>
        [Fact]
        public void Test_Basket_Scenario3()
        {
            var basket = new CustomerBasket();
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());

            Assert.Equal(3.45, basket.TotalCost(), 2);
        }

        /// <summary>
        /// Given the basket has 2 butter, 1 bread and 8 milk when I total the basket then the total should be £9.00
        /// </summary>
        [Fact]
        public void Test_Basket_Scenario4()
        {
            var basket = new CustomerBasket();
            basket.AddProduct(new Butter());
            basket.AddProduct(new Butter());
            basket.AddProduct(new Bread());
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());
            basket.AddProduct(new Milk());

            Assert.Equal(9.00, basket.TotalCost(), 2);
        }
    }
}