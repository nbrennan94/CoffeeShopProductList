using CoffeeShopProductList.Models;

namespace CoffeeShopProductList
{
    public class ProductRepository
    {
        private List<ProductViewModel> _mockProducts;

        public ProductRepository()
        {
            CreateMockProductList();
        }

        private void CreateMockProductList()
        {
            _mockProducts = new List<ProductViewModel>();
            _mockProducts.Add(new ProductViewModel { Id = 1, Name = "Americano", Description = "Espresso + Hot Water", Price = 3.00, Category = "Beverage" });
            _mockProducts.Add(new ProductViewModel { Id = 2, Name = "Cappuccino", Description = "Espresso + Steamed Milk + Foam", Price = 3.50, Category = "Beverage" });
            _mockProducts.Add(new ProductViewModel { Id = 3, Name = "Caramel Macchiato", Description = "Espresso + Steamed Milk + Vanilla Syrup + Caramel Drizzle", Price = 4.45, Category = "Beverage" });
            _mockProducts.Add(new ProductViewModel { Id = 4, Name = "Iced Coffee", Description = "Coffee + Ice", Price = 2.65, Category = "Beverage" });
            _mockProducts.Add(new ProductViewModel { Id = 5, Name = "Matcha Tea Latte", Description = "Matcha + Steamed Milk", Price = 5.00, Category = "Beverage" });
            _mockProducts.Add(new ProductViewModel { Id = 6, Name = "Banana Bread", Description = "Bananas, walnuts and pecans", Price = 3.50, Category = "Food" });
            _mockProducts.Add(new ProductViewModel { Id = 7, Name = "Coffee Cake", Description = "Cinnamon coffee cake with streusel topping", Price = 4.00, Category = "Food" });
            _mockProducts.Add(new ProductViewModel { Id = 8, Name = "Chocolate Croissant", Description = "Butter crossaint with chocolate inside", Price = 4.00, Category = "Food" });
            _mockProducts.Add(new ProductViewModel { Id = 9, Name = "Lemon-Blueberry Muffin", Description = "Lemon muffin with fresh blueberries", Price = 3.00, Category = "Food" });
            _mockProducts.Add(new ProductViewModel { Id = 10, Name = "Scone of the Day", Description = "Flavors include: Chocolate Chip, Blueberry, and Apple Cinnamon", Price = 3.50, Category = "Food" });
        }

        public IEnumerable<ProductViewModel> GetMockProducts()
        {
            return _mockProducts;
        }
    }
}
