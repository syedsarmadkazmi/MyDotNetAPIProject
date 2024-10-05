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
            new Product { Id = 2, Sku = "ELE002", Name = "Laptop", Description = "A high-performance laptop.", Price = 1299, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 3, Sku = "ELE003", Name = "Smartwatch", Description = "A smartwatch with health tracking.", Price = 199, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 4, Sku = "ELE004", Name = "Wireless Earbuds", Description = "Noise-cancelling wireless earbuds.", Price = 149, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 5, Sku = "ELE005", Name = "4K TV", Description = "A 55-inch 4K Ultra HD TV.", Price = 499, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 6, Sku = "ELE006", Name = "Bluetooth Speaker", Description = "A portable Bluetooth speaker.", Price = 99, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 7, Sku = "ELE007", Name = "Tablet", Description = "A high-resolution tablet.", Price = 399, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 8, Sku = "ELE008", Name = "Gaming Console", Description = "A next-gen gaming console.", Price = 499, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 9, Sku = "ELE009", Name = "Digital Camera", Description = "A DSLR camera with a 24MP sensor.", Price = 799, IsAvailable = true, CategoryId = 1 },
            new Product { Id = 10, Sku = "ELE010", Name = "Drone", Description = "A drone with 4K video capabilities.", Price = 899, IsAvailable = true, CategoryId = 1 },

            // Products for Books
            new Product { Id = 11, Sku = "BOO001", Name = "The Great Gatsby", Description = "A classic novel by F. Scott Fitzgerald.", Price = 10, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 12, Sku = "BOO002", Name = "1984", Description = "A dystopian novel by George Orwell.", Price = 15, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 13, Sku = "BOO003", Name = "To Kill a Mockingbird", Description = "A novel by Harper Lee.", Price = 12, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 14, Sku = "BOO004", Name = "The Catcher in the Rye", Description = "A novel by J.D. Salinger.", Price = 14, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 15, Sku = "BOO005", Name = "Sapiens", Description = "A history of humankind by Yuval Noah Harari.", Price = 20, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 16, Sku = "BOO006", Name = "Atomic Habits", Description = "A self-improvement book by James Clear.", Price = 18, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 17, Sku = "BOO007", Name = "Becoming", Description = "A memoir by Michelle Obama.", Price = 25, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 18, Sku = "BOO008", Name = "The Power of Habit", Description = "A book by Charles Duhigg on habit formation.", Price = 16, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 19, Sku = "BOO009", Name = "Educated", Description = "A memoir by Tara Westover.", Price = 22, IsAvailable = true, CategoryId = 2 },
            new Product { Id = 20, Sku = "BOO010", Name = "The Alchemist", Description = "A philosophical book by Paulo Coelho.", Price = 14, IsAvailable = true, CategoryId = 2 },

            // Products for Clothing
            new Product { Id = 21, Sku = "CLO001", Name = "T-shirt", Description = "A comfortable cotton t-shirt.", Price = 25, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 22, Sku = "CLO002", Name = "Jeans", Description = "Classic blue denim jeans.", Price = 50, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 23, Sku = "CLO003", Name = "Jacket", Description = "A stylish leather jacket.", Price = 120, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 24, Sku = "CLO004", Name = "Sneakers", Description = "Comfortable running shoes.", Price = 80, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 25, Sku = "CLO005", Name = "Socks", Description = "Warm woolen socks.", Price = 10, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 26, Sku = "CLO006", Name = "Sweater", Description = "A cozy wool sweater.", Price = 60, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 27, Sku = "CLO007", Name = "Scarf", Description = "A stylish winter scarf.", Price = 35, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 28, Sku = "CLO008", Name = "Cap", Description = "A baseball cap.", Price = 20, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 29, Sku = "CLO009", Name = "Shorts", Description = "Comfortable cotton shorts.", Price = 30, IsAvailable = true, CategoryId = 3 },
            new Product { Id = 30, Sku = "CLO010", Name = "Belt", Description = "A leather belt.", Price = 40, IsAvailable = true, CategoryId = 3 },

            // Products for Furniture
            new Product { Id = 31, Sku = "FUR001", Name = "Sofa", Description = "A comfortable 3-seater sofa.", Price = 800, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 32, Sku = "FUR002", Name = "Dining Table", Description = "A modern wooden dining table.", Price = 600, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 33, Sku = "FUR003", Name = "Office Chair", Description = "An ergonomic office chair.", Price = 150, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 34, Sku = "FUR004", Name = "Bookshelf", Description = "A tall wooden bookshelf.", Price = 120, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 35, Sku = "FUR005", Name = "Bed Frame", Description = "A king-sized bed frame.", Price = 700, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 36, Sku = "FUR006", Name = "Coffee Table", Description = "A modern glass coffee table.", Price = 250, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 37, Sku = "FUR007", Name = "TV Stand", Description = "A wooden TV stand.", Price = 200, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 38, Sku = "FUR008", Name = "Wardrobe", Description = "A large wooden wardrobe.", Price = 950, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 39, Sku = "FUR009", Name = "Recliner Chair", Description = "A comfortable recliner chair.", Price = 450, IsAvailable = true, CategoryId = 4 },
            new Product { Id = 40, Sku = "FUR010", Name = "Nightstand", Description = "A wooden nightstand.", Price = 100, IsAvailable = true, CategoryId = 4 },

            // Products for Toys
            new Product { Id = 41, Sku = "TOY001", Name = "Action Figure", Description = "A superhero action figure.", Price = 25, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 42, Sku = "TOY002", Name = "Lego Set", Description = "A building block set for kids.", Price = 50, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 43, Sku = "TOY003", Name = "RC Car", Description = "A remote-controlled car.", Price = 40, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 44, Sku = "TOY004", Name = "Puzzle", Description = "A 500-piece jigsaw puzzle.", Price = 15, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 45, Sku = "TOY005", Name = "Board Game", Description = "A fun family board game.", Price = 30, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 46, Sku = "TOY006", Name = "Dollhouse", Description = "A miniature dollhouse.", Price = 80, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 47, Sku = "TOY007", Name = "Stuffed Animal", Description = "A soft plush teddy bear.", Price = 20, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 48, Sku = "TOY008", Name = "Train Set", Description = "A toy train with tracks.", Price = 60, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 49, Sku = "TOY009", Name = "Bicycle", Description = "A small children's bicycle.", Price = 100, IsAvailable = true, CategoryId = 5 },
            new Product { Id = 50, Sku = "TOY010", Name = "Yo-Yo", Description = "A classic toy yo-yo.", Price = 10, IsAvailable = true, CategoryId = 5 }
        );
    }
}
