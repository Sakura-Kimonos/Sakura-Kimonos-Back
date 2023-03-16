﻿using Entities.Entities;
using Resources.FilterModels;
using Resources.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IProductLogic
    {
        int AddProduct(ProductItem productItem);
        List<ProductItem> GetAllProducts();
        List<ProductItem> GetProductByCriteria(ProductFilter productFilter);
        void DeactivateProduct(int id);
        void DeleteProduct(int id);
        void UpdateProduct(ProductItem productItem);
    }
}