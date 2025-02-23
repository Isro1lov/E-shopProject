using e_shop.Domain.Entities.Order;

namespace e_shop.DataAccess.Services;

public interface IOrderItemService
{
    Task AddOrderItem(OrderItem orderItem);
    void UpdateOrderItem(OrderItem orderItem);
    void DeleteOrderItem(OrderItem orderItem);
    int SaveChanges();

}
public class OrderItemService : IOrderItemService
{
    private readonly ShopContext _context;

    public OrderItemService(ShopContext context)
    {
        _context = context;
    }
    public async Task AddOrderItem(OrderItem orderItem)
    {
        await _context.OrderItems.AddAsync(orderItem);
        Console.WriteLine(_context.Entry(orderItem).State);
    }

    public void UpdateOrderItem(OrderItem orderItem)
    {
        _context.OrderItems.Update(orderItem);
        Console.WriteLine(_context.Entry(orderItem).State);
    }

    public void DeleteOrderItem(OrderItem orderItem)
    {
        _context.OrderItems.Remove(orderItem);
        Console.WriteLine(_context.Entry(orderItem).State);
    }

    public int SaveChanges() => _context.SaveChanges();
}