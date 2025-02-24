using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.Models;

namespace OrderManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>();
        public IActionResult Index()
        {
            var products = new List<Product>
            {
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 199.99M,
                Description = "This is the description for product 1.",
                ImageUrl = "https://via.placeholder.com/150"
            },
            new Product
            {
                Id = 2,
                Name = "Product 2",
                Price = 299.99M,
                Description = "This is the description for product 2.",
                ImageUrl = "https://via.placeholder.com/150"
            },
            new Product
            {
                Id = 3,
                Name = "Product 3",
                Price = 399.99M,
                Description = "This is the description for product 3.",
                ImageUrl = "https://via.placeholder.com/150"
            },
            new Product
            {
                Id = 4,
                Name = "Product 4",
                Price = 499.99M,
                Description = "This is the description for product 4.",
                ImageUrl = "https://via.placeholder.com/150"
            },
            new Product
            {
                Id = 5,
                Name = "Product 5",
                Price = 599.99M,
                Description = "This is the description for product 5.",
                ImageUrl = "https://via.placeholder.com/150"
            }
            };
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(products);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.Id = products.Count + 1; 
                products.Add(product);
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var existingProduct = products.Find(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
                existingProduct.ImageUrl = product.ImageUrl;
                return RedirectToAction("Index");
            }
            return NotFound();
        }

        public IActionResult Delete(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}

