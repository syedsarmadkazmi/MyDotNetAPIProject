using Microsoft.EntityFrameworkCore;

namespace MyDotNetAPIProject;

public static class ModelBuilderSeedExtension
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Books" },
            new Category { Id = 3, Name = "Clothing" },
            new Category { Id = 4, Name = "Furniture" },
            new Category { Id = 5, Name = "Toys" }
        );

        // Seed Products
        modelBuilder.Entity<Product>().HasData(
            // Products for Electronics
            new Product { Id = 1, Sku = "ELE001", Name = "Smartphone", Description = "A powerful smartphone.", Price = 699, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 2, Sku = "ELE002", Name = "Laptop", Description = "A high-end laptop.", Price = 1200, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 3, Sku = "ELE003", Name = "Headphones", Description = "Noise-canceling headphones.", Price = 199, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 4, Sku = "ELE004", Name = "Smartwatch", Description = "A smartwatch with health features.", Price = 249, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 5, Sku = "ELE005", Name = "Tablet", Description = "A portable tablet.", Price = 499, IsAvailable = true, CategoryId = 1 },

            // Products for Books
            new Product { Id = 6, Sku = "BOOK001", Name = "C# Programming", Description = "A comprehensive guide to C#.", Price = 49, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 7, Sku = "BOOK002", Name = "ASP.NET Core", Description = "Learn ASP.NET Core.", Price = 59, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 8, Sku = "BOOK003", Name = "Design Patterns", Description = "Classic design patterns in software.", Price = 39, IsAvailable = true, CategoryId = 2 }

            // More products for other categories can be added here...
        );
    }
}
