using Microsoft.AspNetCore.Mvc;
using OrderManagementSystem.Models;

namespace OrderManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        // Hardcoded list of products for demo purposes
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop.", Price = 1200.00m, ImageUrl = "https://www.google.com/imgres?q=laptop&imgurl=https%3A%2F%2Fssl-product-images.www8-hp.com%2Fdigmedialib%2Fprodimg%2Flowres%2Fc08484166.png&imgrefurl=https%3A%2F%2Fwww.hp.com%2Flk-en%2Fproducts%2Flaptops%2Fproduct-details%2F2101693839&docid=ONY8gCfbSy9poM&tbnid=LcrrGy1uA4HpPM&vet=12ahUKEwjY1vSC9tuLAxWNTmwGHQIOLd8QM3oECBwQAA..i&w=800&h=600&hcb=2&ved=2ahUKEwjY1vSC9tuLAxWNTmwGHQIOLd8QM3oECBwQAA" },
            new Product { Id = 2, Name = "Smartphone", Description = "Latest model smartphone.", Price = 800.00m, ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.ubuy.com.lk%2Fen%2Fproduct%2FLSIAPU5EO-mini-smartphone-3g-unlocked-3-0-inch-quad-core-216gb-smallest-mobile-phone-android-kids-cell-phones-hd-camera-dual-sim-small-cute-students-palm-child&psig=AOvVaw1nnzL2_le7m54g89t8RiSf&ust=1740473266937000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCMjeoKn224sDFQAAAAAdAAAAABAP" },
            new Product { Id = 3, Name = "Headphones", Description = "Noise-cancelling wireless headphones.", Price = 150.00m, ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fsadadstore.com%2Fproduct%2Fsoundcore-by-anker-q20i-headset%2F&psig=AOvVaw1bWd6esNatqGguH3WZmtKw&ust=1740473295923000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCLi96rX224sDFQAAAAAdAAAAABAU" }
        };

        // GET: Product/Index
        public IActionResult Index()
        {
            return View(products);  // Pass the list of products to the view
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View(new Product());  // Pass an empty product object for the form
        }

        // POST: Product/Create
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                // Add the new product to the list
                product.Id = products.Count + 1;  // Assign a new ID based on the current count
                products.Add(product);

                // Redirect to the Product index page after adding the product
                return RedirectToAction("Index");
            }

            // If model is invalid, return to the same page with error messages
            return View(product);
        }
    }
}

