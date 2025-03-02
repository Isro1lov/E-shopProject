using E_shop.Application.Dtos;
using e_shop.DataAccess;
using FluentValidation;

namespace E_shop.Application.Validators;

public class CreateOrderRequestDtoValidator : AbstractValidator<CreateOrderRequestDto>
{
    public CreateOrderRequestDtoValidator()
    {
        RuleFor(r=>r.CustomerId)
            .NotEmpty()
            .Custom(ValidateCustomer);

        var orderItemValidator = new CreateOrderItemRequestDtoValidator();

        RuleFor(r => r.OrderItems)
            .NotEmpty()
            .ForEach(r => r.NotNull());
            //.ForEach(r=>r.SetValidator(orderItemValidator));
        
        RuleForEach(r=>r.OrderItems)
            .ChildRules(r=>r
                .RuleFor(r=>r.Price)
                .GreaterThanOrEqualTo(0));
            
    }
    public void ValidateCustomer(int customerID, ValidationContext<CreateOrderRequestDto> context)
    {
        using var dbContext = new ShopContext();
        
        var isCustomerExist = dbContext.Customers.Any(c => c.Id == customerID);

        if (!isCustomerExist)
        {
            context.AddFailure($"Customer does not exist for: {customerID}");
        }
    }
    
}


