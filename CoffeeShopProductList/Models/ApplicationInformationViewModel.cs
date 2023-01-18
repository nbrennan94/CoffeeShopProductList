namespace CoffeeShopProductList.Models
{
    public class ApplicationInformationViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string Developer { get; set; }
        public List<string> Tags { get; set; }
    }
}
