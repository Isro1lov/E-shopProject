
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities.Tag;

public class ProductTag
{ 
    public int? TagId { get; set; }

    public Tag Tag { get; set; }

    public int? ProductId { get; set; }

    public Product Product { get; set; }
}