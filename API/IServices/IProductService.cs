using Entities.Entities;
using Resources.FilterModels;
using Resources.RequestModels;

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
