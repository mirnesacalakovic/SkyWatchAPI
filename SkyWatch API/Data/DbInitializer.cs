using Microsoft.AspNetCore.Identity;
using SkyWatch_API.Models;

namespace SkyWatch_API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(SkyContext context, UserManager<User> userManager )
        {
            if (!userManager.Users.Any())
            {
                var user = new User
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "bob@test.com",
                    Email = "bob@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                var admin = new User
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "admin@test.com",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new[] { "Member", "Admin"});

                var tech = new User
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "tech@test.com",
                    Email = "tech@test.com"
                };

                await userManager.CreateAsync(tech, "Pa$$w0rd");
                await userManager.AddToRolesAsync(tech, new[] { "Member", "Tech" }); ;
            }


            context.SaveChanges();
        }
    }
}
