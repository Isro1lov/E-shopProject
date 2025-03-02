
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities;
public class StaffAccount
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public Role Role { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public string PasswordHash { get; set; }

    public bool Active { get; set; } = true;

    public string Image { get; set; }

    public string Placeholder { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;

    public int CreatedBy { get; set; }

    public int UpdatedBy { get; set; }

    // public StaffAccount CreatedByAccount { get; set; }
    //
    // public StaffAccount UpdatedByAccount { get; set; }
}