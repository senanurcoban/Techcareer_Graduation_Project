using Microsoft.EntityFrameworkCore;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-OVRC34F\\SQLEXPRESS;database=PizzaPanDB;Trusted_Connection=true;TrustServerCertificate=true;integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<OurTeam> OurTeams { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

    }
}
