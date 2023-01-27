using DevicesMarket.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace DevicesMarket.Domain
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<TextField> TextFields { get; set; } 
        public DbSet<Product> Products { get; set; } 

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // entities для профиля админа и его роли
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "57ad6275-916f-4833-9a52-b03e8618f098",
                Name = "ADMIN",
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "c95c03b8-eaa0-43c3-a599-ff54348bd6d8",
                UserName = "ADMIN",
                Email = "d.pacooloff@gmail.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "strogpass"),
                SecurityStamp = String.Empty,
            }) ;

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "57ad6275-916f-4833-9a52-b03e8618f098",
                UserId = "c95c03b8-eaa0-43c3-a599-ff54348bd6d8",
            });

            // entities под конкретные таблицы

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("6e73bb01-0175-4556-ac6d-4a8981bf2f4a"),
                CodeWord = "PageIndex",
                Title = "Главная",
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4cd3428e-8347-47a0-8835-f701c2149381"),
                CodeWord = "PageCatalog",
                Title = "Каталог",
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("ef0e810f-a0b5-46f1-953d-339532940bfd"),
                CodeWord = "PageContacts",
                Title = "Контакты",
            });
        }
    }
}
