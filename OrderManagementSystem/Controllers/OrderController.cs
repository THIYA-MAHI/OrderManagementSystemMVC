using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.Models;

namespace OrderManagementSystem.Controllers
{
    public class OrderController : Controller
    {
        private static List<Order> orders = new List<Order>
        {
            new Order { Id = 1, OrderNumber = "ORD001", ProductName = "Product A", Quantity = 2, TotalPrice = 40.00m, Status = "Shipped" },
            new Order { Id = 2, OrderNumber = "ORD002", ProductName = "Product B", Quantity = 1, TotalPrice = 25.00m, Status = "Pending" },
            new Order { Id = 3, OrderNumber = "ORD003", ProductName = "Product C", Quantity = 5, TotalPrice = 100.00m, Status = "Delivered" },
            new Order { Id = 4, OrderNumber = "ORD004", ProductName = "Product D", Quantity = 3, TotalPrice = 75.00m, Status = "Shipped" },
            new Order { Id = 5, OrderNumber = "ORD005", ProductName = "Product E", Quantity = 4, TotalPrice = 120.00m, Status = "Pending" }
        };
        public IActionResult Index()
        {
            return View(orders);
        }
    }
}
