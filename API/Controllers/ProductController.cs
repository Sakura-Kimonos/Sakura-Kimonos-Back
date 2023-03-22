using API.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources.FilterModels;
using Resources.RequestModels;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost(Name = "AddProduct")]
        public int AddProduct([FromBody] ProductRequest productRequest)
        {
            return _productService.AddProduct(productRequest);
        }

        [HttpGet(Name = "GetAllProducts")]
        public List<ProductItem> GetAllProducts()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet(Name = "GetProductByCriteria")]
        public List<ProductItem> GetByCriteria([FromQuery] ProductFilter productFilter)
        {
            return _productService.GetProductByCriteria(productFilter);
        }

        [HttpGet(Name= "GetProductById")]
        public List<ProductItem> GetProductById([FromQuery] int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPatch(Name = "UpdateProduct")]
        public void Patch([FromBody] ProductItem productItem)
        {
            _productService.UpdateProduct(productItem);
        }

        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromQuery] int id)
        {
            _productService.DeleteProduct(id);
        }

        [HttpDelete(Name = "DeactivateProduct")]
        public void DeactivateProduct([FromQuery] int id)
        {
            _productService.DeactivateProduct(id);
        }
    }
}