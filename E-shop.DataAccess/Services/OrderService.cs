using e_shop.Domain.Entities;
using e_shop.Domain.Entities.Order;

namespace e_shop.DataAccess.Services;

public interface IOrderService
{
    Task AddOrder(Order order);
    void UpdateOrder(Order order);
    void DeleteOrder(Order order);
    int SaveChanges();
}
public class OrderService : IOrderService
{
    private readonly ShopContext _context;

    public OrderService(ShopContext context)
    {
        _context = context;
    }
    
    public async Task AddOrder(Order order)
    {
        await _context.Orders.AddAsync(order);
        Console.WriteLine(_context.Entry(order).State);
    }

    public void UpdateOrder(Order order)
    {
        _context.Orders.Update(order);
        Console.WriteLine(_context.Entry(order).State);
    }

    public void DeleteOrder(Order order)
    {
        _context.Orders.Remove(order);
        Console.WriteLine(_context.Entry(order).State);
    }

    public int SaveChanges() => _context.SaveChanges();
}