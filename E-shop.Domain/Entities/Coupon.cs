
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities;
public class Coupon
{
    public int Id { get; set; }

    public string Code { get; set; }

    public decimal? DiscountValue { get; set; }

    public string DiscountType { get; set; }

    public decimal TimesUsed { get; set; } = 0;

    public decimal? MaxUsage { get; set; }

    public decimal? OrderAmountLimit { get; set; }

    public DateTime? CouponStartDate { get; set; }

    public DateTime? CouponEndDate { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public StaffAccount CreatedByAccount { get; set; }

    public StaffAccount UpdatedByAccount { get; set; }
}