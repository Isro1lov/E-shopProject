namespace e_shop.Domain.Entities.Customer;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cart
{
    public int Id { get; set; }
    
    public int? CustomerId { get; set; }
    
    public Customer Customer { get; set; }
    public ICollection<CartItem> CartItems { get; set; }
}