using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Samsung S8 Plus", ImageUrl = "1.jpg", Price= 3000 },
                new Product() { Id = 2, Name = "Samsung S9 Plus", ImageUrl = "2.jpg", Price= 6000 },
                new Product() { Id = 3, Name = "Samsung S10 Plus", ImageUrl = "3.jpg", Price= 8000 },

            };

            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
