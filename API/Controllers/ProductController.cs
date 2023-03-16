using API.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources.FilterModels;
using Resources.RequestModels;


namespace API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        //private readonly IUserSecurityService _userSecurityService;
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

        [HttpGet(Name = "GetProductByCriteria")]
        public List<ProductItem> GetByCriteria([FromQuery] ProductFilter productFilter)
        {
            return _productService.GetProductByCriteria(productFilter);
        }

        [HttpDelete(Name = "DeactivateProduct")]
        public void DeactivateProduct([FromQuery] int id)
        {
            _productService.DeactivateProduct(id);
        }
    }
}
