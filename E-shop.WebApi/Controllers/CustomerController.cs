using System.Text;
using e_shop.DataAccess;
using E_shop.DataAccess;
using e_shop.Domain.Entities.Customer;
using E_shop.WebApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    [HttpGet("all-customers")]
    // GET
    public IActionResult GetAllCustomers()
    {
        using var context = new ShopContext();
        var customers = context
            .Customers
            .Select(r => new CustomerDto()
            {
                ID = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                PhoneNumber = r.PhoneNumber,
                Password = Encoding.UTF8.GetString(Convert.FromBase64String(r.Password))
            })
            .ToList();
        
        return Ok(customers);
    }
    
    [HttpPost("add-customer")]

    public async Task<IActionResult> AddCustomer([FromBody] CustomerDto customerDto)
    { 
        
        var customer = new Customer
        {
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "123456789",
            Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(customerDto.Password)),
            Active = true
        };
        
        await using var context = new ShopContext();
        await context.Customers.AddAsync(customer);
        await context.SaveChangesAsync();
        return Ok();
    }
    
    
}