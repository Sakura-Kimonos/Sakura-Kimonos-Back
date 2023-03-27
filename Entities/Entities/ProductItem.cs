
namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {

            IsActive = true;
            IsPublic = true;

        }

        public int Id { get; set; }
        public int IdPhotoFile { get; set; }
        public Guid IdWeb { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
        public string Season { get; set; }
        public string Pattern { get; set; }
        public int Units { get; set; }

        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }

        public DateTime UpdateDate { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
