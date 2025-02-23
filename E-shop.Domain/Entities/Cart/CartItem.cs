namespace e_shop.Domain.Entities.Customer;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class CartItem
{
    public int Id { get; set; }                  
    public int? CardId { get; set; }
    public Cart Cart { get; set; }

    public int? ProductId { get; set; }
    
    public Product Product { get; set; }

    public int Quantity { get; set; } = 1;
}