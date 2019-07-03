using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void Create(Product entity);

        void Update(Product entity);

        void Delete(Product entity);
    }
}
