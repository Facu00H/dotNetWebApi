using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Features.Products.DTOs
{
    public class CreateProductDTO
    {
        [Required]
        [NotNull]
        [MinLength(40, ErrorMessage = "you must enter les than 40 characters")]
        [MaxLength(2, ErrorMessage = "you must enter more than 2 characters")]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "Please enter a valid number between 0 and 100")]
        public int Stock { get; set; }

        [MaxLength(40, ErrorMessage = "you must enter more than 40 characters")]
        [MinLength(160, ErrorMessage = "you must enter less than 160 characters")]
        public string? Description { get; set; }
    }
}
