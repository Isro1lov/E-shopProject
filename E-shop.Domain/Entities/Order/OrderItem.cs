
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities.Order;

public class OrderItem 
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public Product Product { get; set; }

    public string OrderId { get; set; }

    public Order Order { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}