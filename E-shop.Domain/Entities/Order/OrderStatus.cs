
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities.Order;
public class OrderStatus
{
    public int Id { get; set; } 

    public string StatusName { get; set; }

    public string Color { get; set; }

    public string Privacy { get; set; } = "private";

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public int CreatedBy { get; set; }

    public int UpdatedBy { get; set; }

    public StaffAccount CreatedByAccount { get; set; }

    public StaffAccount UpdatedByAccount { get; set; }
}