using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productService;

        public ProductManager(IProductDal productService)
        {
            _productService = productService;
        }
        public void Create(Product entity)
        {
            _productService.Create(entity);
        }
        public void Delete(Product entity)
        {
            _productService.Delete(entity);
        }
        public IEnumerable<Product> GetAll()
        {
            return _productService.GetAll();
        }
        public Product GetById(int id)
        {
            return _productService.GetById(id);
        }
        public void Update(Product entity)
        {
            _productService.Update(entity);
        }
    }
}
