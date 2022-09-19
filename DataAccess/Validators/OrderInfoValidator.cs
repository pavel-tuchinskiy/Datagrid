using Domain.DTOs.OrderInfo;
using Domain.DTOs.Product;
using FluentValidation;

namespace DataAccess.Validators
{
    public class OrderInfoPostValidator : AbstractValidatorCustom<OrderInfoPostDTO>
    {
        public OrderInfoPostValidator()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address field is required");
            RuleFor(x => x.Products).NotEmpty().WithMessage("Products can't be empty");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserId is required");
        }
    }

    public class OrderInfoUpdateValidator : AbstractValidatorCustom<OrderInfoUpdateDTO>
    {
        public OrderInfoUpdateValidator()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address field is required");
            RuleFor(x => x.Products).NotEmpty().WithMessage("Products can't be empty");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserId is required");
            RuleFor(x => x.Status).IsInEnum().WithMessage("Status field is required");
            RuleFor(x => x.OrderDate).GreaterThanOrEqualTo(DateTime.Parse(Constants.ORDER_DATE_MIN)).LessThanOrEqualTo(DateTime.Now)
                .WithMessage($"OrderDate must be greater then {DateTime.Parse(Constants.ORDER_DATE_MIN)} and less then {DateTime.Now.Date}");
        }
    }
    public class OrderInfoProductValidator : AbstractValidatorCustom<ProductOrderInfoCreateUpdateDTO>
    {
        public OrderInfoProductValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId is required");
        }
    }
}
