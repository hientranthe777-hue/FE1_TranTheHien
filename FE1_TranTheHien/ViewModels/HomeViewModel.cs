using FE1_TranTheHien.Models;
using System.Collections.Generic;

namespace FE1_TranTheHien.ViewModels
{
    public class HomeViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> FeaturedProducts { get; set; }
    }
}