namespace E_shop.Application.Dtos;

public class CreateOrderItemRequestDto
{
    public int ProductId { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}