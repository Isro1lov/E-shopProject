using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        
        public int? ParentId { get; set; }
        public string CategoryName { get; set; }
        
        public string CategoryDescription { get; set; }
        
        public string Icon {  get; set; }         
        
        public string ImagePath{ get; set; }
        public bool Active{ get; set; }
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAt { get; set; }
        
        public int CreatedBy { get; set; }
        
        public int UpdatedBy { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}