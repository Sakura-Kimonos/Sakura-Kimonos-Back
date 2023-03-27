using Entities.Entities;

namespace API.Models
{
    public class ProductForm
    { 
        
            public string Title { get; set; }
            public int IdPhotoFile { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
            public string Category { get; set; }
            public string Material { get; set; }
            public string Season { get; set; }
            public string Pattern { get; set; }
            public int Units { get; set; }
            public ProductItem ToProductItem()
            {
            ProductItem productItem = new ProductItem();

                productItem.Title = Title;
                productItem.Description = Description;
                productItem.Price = Price;
                productItem.Category = Category;
                productItem.Material = Material;
                productItem.Season = Season;
                productItem.Pattern = Pattern;
                productItem.Units = Units;



                productItem.AddedDate = DateTime.Now;
                productItem.UpdateDate = DateTime.Now;
                productItem.IsActive = true;
                productItem.IsPublic = true;
                return productItem;
            }
        }
    }


