using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
