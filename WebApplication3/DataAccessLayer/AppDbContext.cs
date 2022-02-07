using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SlidersImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<about> About { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<ExpertTitle> ExpertsTitle { get; set; }
    }
}
