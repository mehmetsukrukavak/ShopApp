using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryService;

        public CategoryManager(ICategoryDal categoryService)
        {
            _categoryService = categoryService;
        }
        public void Create(Category entity)
        {
            _categoryService.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryService.Delete(entity);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryService.GetById(id);
        }

        public void Update(Category entity)
        {
            _categoryService.Update(entity);
        }
    }
}
