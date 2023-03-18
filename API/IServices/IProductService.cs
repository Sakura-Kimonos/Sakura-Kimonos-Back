using Entities.Entities;
using Resources.FilterModels;
using Resources.RequestModels;
using Microsoft.AspNetCore.Mvc;
using API.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;

namespace API.IServices
{
    public interface IProductService
    {
            int AddProduct(ProductRequest productRequest);
            List<ProductItem> GetAllProducts();
            List<ProductItem> GetProductByCriteria(ProductFilter productFilter);
            void DeactivateProduct(int id);
            void DeleteProduct(int id);
            void UpdateProduct(ProductItem productItem);
    }
}
