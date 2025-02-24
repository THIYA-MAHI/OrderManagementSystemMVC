using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
