
using System.ComponentModel.DataAnnotations;

namespace Restaurants.Application.Dtos
{
    public class CreateRestaurantDto
    {
        [StringLength(100,MinimumLength =3)]
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        [Required(ErrorMessage ="Insert a valid category")]
        public string Category { get; set; } = default!;
        public bool HasDelivery { get; set; }
        [EmailAddress(ErrorMessage ="Enter valid Email")]
        public string? ContactEmail { get; set; }
        [Phone(ErrorMessage ="Please provide valid phone")]
        public string? ContactNumber { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        [RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage ="Please provide valid postal code")]
        public string? PostalCode { get; set; }
    }
}
