using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShopProductList.Models;

namespace CoffeeShopProductList.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository repo;

        public ProductController()
        {
            repo = new ProductRepository();
        }

        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(repo.GetMockProducts());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            ProductViewModel product = repo.GetMockProducts().FirstOrDefault(x => x.Id == id);
            return View(product);
        }

    }
}
