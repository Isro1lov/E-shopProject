
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities.Tag;

public class Tag
{
    public int Id { get; set; }
    public string TagName { get; set; }
    public string Icon { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public ICollection<ProductTag>? ProductTags { get; set; }

    // [ForeignKey("CreatedBy")]
    // public StaffAccount CreatedByAccount { get; set; }
    //
    // [ForeignKey("UpdatedBy")]
    // public StaffAccount UpdatedByAccount { get; set; }
}