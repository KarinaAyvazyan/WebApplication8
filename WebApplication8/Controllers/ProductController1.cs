using Microsoft.AspNetCore.Mvc;
using OnlineShop.Core.Interfaces;

namespace WebApplication8.Controllers
{
    public class ProductController1 : Controller
    {
        private readonly IProductService _productService;

        public ProductController1(IProductService productService)
        {
            _productService = productService;
           
        }
    
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
