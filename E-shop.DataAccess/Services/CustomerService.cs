using e_shop.Domain.Entities;
using e_shop.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess.Services;

public class CustomerService
{
    private readonly ShopContext _context;
    public CustomerService(ShopContext context)
    {
        _context = context;
    }

    public async Task AddCustomer(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
    }

    public async Task AddCustomerAddress(CustomerAddress customerAddress)
    {
        await _context.CustomerAddress.AddAsync(customerAddress);
    }

    public IEnumerable<Customer> GetCustomers()
    {
        return _context.Customers
            .Include(r => r.CustomerAddress);
    }
    
    public int SaveChanges() => _context.SaveChanges();
}

