
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using e_shop.Domain.Entities.Tag;

namespace e_shop.Domain.Entities

{
    public class Product
    {
        public Product()
        {
            Categories = new List<Category>();
        }
        public int Id { get; set; } 
        public string SKU{ get; set; }
        public string ProductName{ get; set; }
        public decimal RegularPrice{ get; set; }
        
        public decimal DiscountPrice{ get; set; }
        
        public int Quantity{ get; set; }
        
        public string ShortDescription {  get; set; }
        
        public string ProductDescription{ get; set; }
        
        public decimal ProductWeight{ get; set; }
        
        public string ProductNote { get; set; }
        
        public bool Published {  get; set; }    
        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public DateTime UpdatedAt { get; set; }
        
        public int CreatedBy { get; set; }   
        
        public int? UpdatedBy { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public ICollection<ProductTag>? ProductTags { get; set; }
    }
}