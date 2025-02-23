namespace e_shop.Domain.Entities.Customer;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CustomerAddress
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    public string AddressLine1 { get; set; }

    public string AddressLine2 { get; set; }

    public string PhoneNumber { get; set; }

    public string DialCode { get; set; }

    public string Country { get; set; }

    public string PostalCode { get; set; }

    public string City { get; set; }
}