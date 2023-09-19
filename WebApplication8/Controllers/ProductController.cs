using Microsoft.AspNetCore.Mvc;
using OnlineShop.Core.Interfaces;

namespace WebApplication8.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
           
        }
    
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
