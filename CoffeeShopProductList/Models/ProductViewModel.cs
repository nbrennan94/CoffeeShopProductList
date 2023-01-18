using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopProductList.Models
{
    public class ProductViewModel
    {
        [DisplayName("Product ID")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        public string Name { get; set; }

        [DisplayName("Product Description")]
        public string? Description { get; set; }

        [DisplayName("Product Price")]
        public double Price { get; set; }

        [DisplayName("Product Category")]
        public string Category { get; set; }
    }
}
