using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SkyWatch_API.Models;

namespace SkyWatch_API
{
    public class SkyContext : IdentityDbContext<User>
    {
        public SkyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole { Name = "Member", NormalizedName = "MEMBER"},
                    new IdentityRole { Name = "Admin", NormalizedName = "ADMIN"},
                    new IdentityRole { Name = "Tech", NormalizedName = "TECH"}
                );
        }

        public DbSet<Alarm> Alarms { get; set; }
    }
}
