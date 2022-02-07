using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.DataAccessLayer;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var sliderImages = _dbContext.SlidersImages.ToList();
            var slider = _dbContext.Sliders.SingleOrDefault();
            var categories = _dbContext.Categories.ToList();
            var products = _dbContext.Products.Include(x => x.Category).ToList();
            var about = _dbContext.About.SingleOrDefault();
            var aboutImage = _dbContext.AboutImages.SingleOrDefault();
            var experts = _dbContext.Experts.ToList();
            var expertstitle = _dbContext.ExpertsTitle.SingleOrDefault();
            return View(new HomeViewModel
            { 
                SliderImages = sliderImages,
                Slider = slider,
                Categories = categories,
                Products = products,
                About = about,
                AboutImage = aboutImage,
                Experts = experts,
                ExpertTitle = expertstitle
            });
        }
    }
}
