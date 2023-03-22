using API.IServices;
using Entities.Entities;
using Logic.ILogic;
using Resources.FilterModels;
using Resources.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        void IProductService.DeactivateProduct(int id)
        {
            _productLogic.DeactivateProduct(id);
        }


        public void DeleteProduct(int id)
        {
            _productLogic.DeleteProduct(id);
        }

        public List<ProductItem> GetAllProducts()
        {
            return _productLogic.GetAllProducts();
        }

        public List<ProductItem> GetProductByCriteria(ProductFilter productFilter)
        {
            return _productLogic.GetProductByCriteria(productFilter);
        }

        public List<ProductItem> GetProductById(int id)
        {
            return _productLogic.GetProductById(id);
        }

        public int AddProduct(ProductRequest productRequest)
        {
            var newProductItem = productRequest.ToProductItem();
            
            return _productLogic.AddProduct(newProductItem);
        }

        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProduct(productItem);
        }
    }
}
