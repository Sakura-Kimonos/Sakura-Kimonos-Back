using API.IServices;
using API.Models;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Web.Http.Cors;



namespace API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        private readonly IFileService _fileService;

       
        public ProductController(IProductService productService, IFileService fileService)
        {
            _productService = productService;
            _fileService = fileService;
        }

        //[HttpGet(Name = "GetProductByCriteria")]
        //public List<ProductItem> GetByCriteria([FromQuery] ProductFilter productFilter)
        //{
        //    return _productService.GetProductByCriteria(productFilter);
        //}

        [HttpGet(Name= "GetProductById")]
        public List<ProductItem> GetProductById([FromQuery] int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPatch(Name = "UpdateProduct")]
        public void UpdateProduct([FromBody] ProductItem productItem)
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

        [HttpGet(Name = "GetAllProduct")]
        public List<ProductItem> GetAllProduct()
        {
            try
            {
                var fileList = _fileService.GetAllImagesList();
                var productList = _productService.GetAllProduct();

                List<Base64FileModel> base64FileList = new List<Base64FileModel>();

                foreach (var file in fileList)
                {
                    Base64FileModel base64FileModel = new Base64FileModel();
                    base64FileModel.FileName = file.Name;
                    base64FileModel.Content = file.Base64Content;
                    base64FileModel.FileExtension = file.FileExtension;
                    base64FileList.Add(base64FileModel);
                    
                }
                return _productService.GetAllProduct();
                //return base64FileList; 
            } catch (Exception ex) { throw; }
          
        }

        [HttpPost(Name = "AddProduct")]
        public int AddProduct([FromBody] NewProductRequest newProductRequest)
        {
            try
            {
                var fileItem = new FileItem();

                fileItem.Id = 0;
                fileItem.Name = newProductRequest.FileData.FileName;
                fileItem.InsertDate = DateTime.Now;
                fileItem.UpdateDate = DateTime.Now;
                fileItem.Content = Convert.FromBase64String(newProductRequest.FileData.Base64FileContent);

                var fileId = _fileService.InsertFile(fileItem);

                var productItem = new ProductItem();
                productItem.Title = newProductRequest.ProductData.Title;
                productItem.Price = newProductRequest.ProductData.Price;
                productItem.Description = newProductRequest.ProductData.Description;
                productItem.Material = newProductRequest.ProductData.Material;
                productItem.Pattern = newProductRequest.ProductData.Pattern;
                productItem.Category = newProductRequest.ProductData.Category;
                productItem.Season = newProductRequest.ProductData.Season;
                productItem.Units = newProductRequest.ProductData.Units;
                productItem.IdPhotoFile = fileId;
                return _productService.AddProduct(productItem);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
 }

