using FluentValidation;
using Restaurants.Application.Dtos;

namespace Restaurants.Application.Validators
{
    public class CreateRestaurantDtoValidator: AbstractValidator<CreateRestaurantDto>
    {
        public CreateRestaurantDtoValidator()
        {
            RuleFor(dto => dto.Name)
                .Length(3, 100);

            RuleFor(dto => dto.Description)
                .NotEmpty().WithMessage("Description is required");

            RuleFor(dto => dto.Category)
                .NotEmpty().WithMessage("Please enter valid category");

            RuleFor(dto => dto.ContactEmail)
                .EmailAddress()
                .WithMessage("please provide a valid email address");

            RuleFor(dto => dto.PostalCode)
                .Matches(@"^\d{2}-\d{3}$")
                .WithMessage("please provide valid postal code");
        }
    }
}
