using System;
using ShopApp.Entities;

namespace ShopApp.WebUI.Models
{
    public class ProductListModel
    {
        public ProductListModel<Product> Products { get; set; }
    }
}
