using API.IServices;
using API.Models;
using API.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Resources.FilterModels;
using Resources.RequestModels;
using System.Web.Http.Cors;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        [Obsolete]
        public ProductController(IProductService productService)
        {
            _productService = productService;
            
        }

        //[HttpPost(Name = "AddProduct")]
        //public int AddProduct([FromForm] ProductUploadModel productUploadModel)
        //{
        //    Copiar código de la web recurso 
        //}

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

        [HttpPost(Name = "AddProduct")]

        public int AddProduct([FromBody] ProductRequest productRequest)
        {
            return _productService.AddProduct(productRequest);
        }
        //public async Task<IActionResult> DemoFormDataUpload([FromForm] ProductUploadModel productUploadModel)
        //{
        //    // Check if the request contains multipart/form-data.
        //    if (productUploadModel.Image == null)
        //    {
        //        return new UnsupportedMediaTypeResult();
        //    }

        //    if (productUploadModel.Image.Length > 0)
        //    {
        //        IFormFile formFile = productUploadModel.Image;

        //        var folderPath = Path.Combine(_environment.WebRootPath, "upload");
        //        //var filePath = Path.Combine(folderPath, $"{Path.GetRandomFileName() + Path.GetExtension(formFile.FileName).ToLowerInvariant()}");
        //        var filePath = Path.Combine(folderPath, formFile.FileName);

        //        if (!Directory.Exists(folderPath))
        //        {
        //            Directory.CreateDirectory(folderPath);
        //        }
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await formFile.CopyToAsync(fileStream);
        //            fileStream.Flush();
        //            return Ok(new { status = "Upload Success", length = formFile.Length, name = formFile.FileName });
        //        }
        //    }
        //    else
        //    {
        //        return NotFound("Failed to upload");
        //    }
        }
 }

