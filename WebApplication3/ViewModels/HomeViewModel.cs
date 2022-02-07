using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class HomeViewModel
    {
        public List<SliderImage> SliderImages { get; set; }
        public Slider Slider { get; set; }

        public List<Product> Products { get; set; }

        public List<Category> Categories { get; set; }

        public about About { get; set; }
        public AboutImage AboutImage { get; set; }
        public ExpertTitle ExpertTitle { get; set; }
        public List<Expert> Experts { get; set; }
    }
    
}
