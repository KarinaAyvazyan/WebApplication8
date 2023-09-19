
using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Areas.Admin.Controllers
{
    public class ProductManageController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
