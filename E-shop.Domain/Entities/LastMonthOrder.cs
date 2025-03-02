namespace e_shop.Domain.Entities;

public class LastMonthOrder
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int OrderStatusId { get; set; }
    public DateTime? OrderApprovedAt { get; set; }
    public DateTime? OrderDeliveredCarrierDate { get; set; }
    public DateTime? OrderDeliveredCustomerDate { get; set; }
    public DateTime CreatedAt { get; set; }
    public int UpdatedBy { get; set; }
    public int UpdatedByAccountId { get; set; }
    
    
}
