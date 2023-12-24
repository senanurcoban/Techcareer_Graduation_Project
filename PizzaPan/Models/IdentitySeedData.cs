using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using PizzaPan.EntityLayer.Concrete;
using PizzaPan.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace PizzaPan.PresentationLayer.Models
{
    public class IdentitySeedData
    {
        private const string adminUser = "admin";
        private const string adminPassword = "Admin_123";
        public static async void IdentityTestUser(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<Context>();

            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }

            var UserManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<AppUser>>();

            var user = await UserManager.FindByIdAsync(adminUser);
            if (user == null)
            {
                user = new AppUser
                {
                    Name = "Sena Coban",
                    Email = "admin@senacoban.com",
                    PhoneNumber = "12345678912"
                };

                await UserManager.CreateAsync(user, adminPassword);
            }

        }
    }
}
