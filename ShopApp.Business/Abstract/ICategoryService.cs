﻿using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();

        Category GetById(int id);

        void Create(Category entity);

        void Update(Category entity);

        void Delete(Category entity);
    }
}
