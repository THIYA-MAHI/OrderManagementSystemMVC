using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.Models;

namespace OrderManagementSystem.Controllers
{
    public class UserController : Controller
    {
     
        public IActionResult Index()
        {
            var users = new List<User>
        {
            new User { Id = 1, UserName = "john_doe", Email = "john.doe@example.com" },
            new User { Id = 2, UserName = "jane_smith", Email = "jane.smith@example.com" },
            new User { Id = 3, UserName = "alice_jones", Email = "alice.jones@example.com" },
            new User { Id = 4, UserName = "bob_brown", Email = "bob.brown@example.com" },
            new User { Id = 5, UserName = "charlie_white", Email = "charlie.white@example.com" }
        };
            return View(users);
        }
        
    }
}
