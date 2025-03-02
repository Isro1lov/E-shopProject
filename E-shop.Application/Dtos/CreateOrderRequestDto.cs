using e_shop.Domain.Entities.Order;

namespace E_shop.Application.Dtos;

public class CreateOrderRequestDto
{
    public int CustomerId { get; set; }

    public List<OrderItem>? OrderItems { get; set; }

}