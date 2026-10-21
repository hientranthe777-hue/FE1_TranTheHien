
using FE1_TranTheHien.Models;
using FE1_TranTheHien.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FE1_TranTheHien.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "WOMEN'S", ImageUrl = "https://images.unsplash.com/photo-1483985988355-763728e1935b?q=80&w=600&auto=format&fit=crop" },
                new Category { Id = 2, Name = "ACCESSORIES", ImageUrl = "https://images.unsplash.com/photo-1509319117193-57bab727e09d?q=80&w=600&auto=format&fit=crop" },
                new Category { Id = 3, Name = "MEN'S", ImageUrl = "https://images.unsplash.com/photo-1516257984-b1b4d707412e?q=80&w=600&auto=format&fit=crop" }
            };

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Leather Jacket", Price = 85.00m, ImageUrl = "https://images.unsplash.com/photo-1551028719-00167b16eac5?q=80&w=400&auto=format&fit=crop", IsSale = true },
                new Product { Id = 2, Name = "White T-Shirt", Price = 250.00m, ImageUrl = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?q=80&w=400&auto=format&fit=crop" },
                new Product { Id = 3, Name = "Black Boots", Price = 145.00m, ImageUrl = "https://images.unsplash.com/photo-1608256246200-53e635b5b65f?q=80&w=400&auto=format&fit=crop" },
                new Product { Id = 4, Name = "Denim Skirt", Price = 270.00m, ImageUrl = "https://images.unsplash.com/photo-1582142407894-ec85a1260a46?q=80&w=400&auto=format&fit=crop", IsNew = true }
            };

            var viewModel = new HomeViewModel
            {
                Categories = categories,
                FeaturedProducts = products
            };

            return View(viewModel);
        }
    }
}