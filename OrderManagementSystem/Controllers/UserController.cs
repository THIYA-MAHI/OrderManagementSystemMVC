using Microsoft.AspNetCore.Mvc;

namespace OrderManagementSystem.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
