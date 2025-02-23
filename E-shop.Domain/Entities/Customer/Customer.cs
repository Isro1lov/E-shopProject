using System.ComponentModel.DataAnnotations.Schema;

namespace e_shop.Domain.Entities.Customer;

using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }
    public bool Active { get; set; } = true;

    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public string PhoneNumber { get; set; }
    public List<CustomerAddress> CustomerAddress { get; set; }
}