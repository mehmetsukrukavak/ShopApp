using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }

                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category() { Name = "Telefon" },
            new Category() { Name = "Bilgisayar" }
        };

        private static Product[] Products =
        {
            new Product(){ Name = "Samsung Galaxy S8", Price=1000, ImageUrl="1.jpg" },
            new Product(){ Name = "Samsung Galaxy S9", Price=2000, ImageUrl="2.jpg" },
            new Product(){ Name = "Samsung Galaxy S10", Price=5000, ImageUrl="3.jpg" },
            new Product(){ Name = "Apple Iphone X", Price=8000, ImageUrl="4.jpg" },
            new Product(){ Name = "Apple MAcbook Air", Price=2000, ImageUrl="5.jpg" },
            new Product(){ Name = "Lenovo Ideapad", Price=2000, ImageUrl="6.jpg" },
            new Product(){ Name = "Samsung", Price=2000, ImageUrl="7.jpg" },
        };
    }
}
