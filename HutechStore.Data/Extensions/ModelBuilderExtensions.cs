using HutechStore.Data.Entities;
using HutechStore.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace HutechStore.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //AppConfig
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of HutechStore" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of HutechStore" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of HutechStore" }
                );

            //Language
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            //Category
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, IsShowOnHome = true, ParentId = null, SortOrder = 1, Status = Status.Active },
                new Category() { Id = 2, IsShowOnHome = true, ParentId = null, SortOrder = 2, Status = Status.Active }
                );

            //CategoryTranslation
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() 
                { 
                    Id = 1, 
                    CategoryId = 1, 
                    Name = "Áo nam", 
                    LanguageId = "vi-VN", 
                    SeoAlias = "ao-nam", 
                    SeoDescription = "Sản phẩm áo thời trang nam", 
                    SeoTitle = "Sản phẩm áo thời trang nam" 
                },
                new CategoryTranslation() 
                { 
                    Id = 2, 
                    CategoryId = 1, 
                    Name = "Men Shirt", 
                    LanguageId = "en-US", 
                    SeoAlias = "men-shirt", 
                    SeoDescription = "The shirt products for men", 
                    SeoTitle = "The shirt products for men" 
                },
                new CategoryTranslation() 
                { 
                    Id = 3, 
                    CategoryId = 2, 
                    Name = "Áo nữ", 
                    LanguageId = "vi-VN", 
                    SeoAlias = "ao-nu", 
                    SeoDescription = "Sản phẩm áo thời trang nữ", 
                    SeoTitle = "Sản phẩm áo thời trang nữ" 
                },
                new CategoryTranslation() 
                { 
                    Id = 4, 
                    CategoryId = 2, 
                    Name = "Women Shirt", 
                    LanguageId = "en-US", 
                    SeoAlias = "women-shirt", 
                    SeoDescription = "The shirt products for women", 
                    SeoTitle = "The shirt products for women" 
                });

            //Product
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, DateCreated = DateTime.Now, OriginalPrice = 100000, Price = 200000, Stock = 0, ViewCount = 0,
                });


            //ProductTranslation
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo sơ mi nam trắng Việt Tiến",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                    SeoDescription = "Áo sơ mi nam trắng Việt Tiến",
                    SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                    Details = "Áo sơ mi nam trắng Việt Tiến",
                    Description = "Áo sơ mi nam trắng Việt Tiến"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Viet Tien Men T-Shirt",
                    LanguageId = "en-US",
                    SeoAlias = "viet-tien-men-t-shirt",
                    SeoDescription = "Viet Tien Men T-Shirt",
                    SeoTitle = "Viet Tien Men T-Shirt",
                    Details = "Viet Tien Men T-Shirt",
                    Description = "Viet Tien Men T-Shirt"
                });


            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );


            // any guid
            var roleId = new Guid("B5B7BCF5-52F7-4E91-96C3-6F020BD84BC3");
            var adminId = new Guid("6A924915-E5B4-4DD5-9D37-81D6DDFA5070");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "kingcter@ptd.edu.vn",
                NormalizedEmail = "kingcter@ptd.edu.vn",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "DungKhoa0TM@1902"),
                SecurityStamp = string.Empty,
                FirstName = "Dung",
                LastName = "Nguyen",
                Dob = new DateTime(2000, 02, 19)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
    
}