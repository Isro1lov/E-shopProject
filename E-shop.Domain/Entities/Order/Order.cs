
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities.Order;

public class Order
{
    public int Id { get; set; }

    public int CouponId { get; set; }

    public Coupon Coupon { get; set; }

    public int CustomerId { get; set; }

    public Customer.Customer Customer { get; set; }

    public int OrderStatusId { get; set; }

    public OrderStatus OrderStatus { get; set; }

    public DateTime? OrderApprovedAt { get; set; }

    public DateTime? OrderDeliveredCarrierDate { get; set; }

    public DateTime? OrderDeliveredCustomerDate { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int UpdatedBy { get; set; }

    public StaffAccount UpdatedByAccount { get; set; }
    
    public ICollection<OrderItem> OrderItems { get; set; }
}