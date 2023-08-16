using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.Features.Products.DTOs
{
    public class CreateProductDTO
    {
        [Required]
        [NotNull]
        [MaxLength(40, ErrorMessage = "Name: you must enter less than 40 characters")]
        [MinLength(2, ErrorMessage = "Name: you must enter more than 2 characters")]
        public string Name { get; set; }

        [Range(0, 100, ErrorMessage = "Stock: Please enter a valid number between 0 and 100")]
        public int Stock { get; set; }

        [MaxLength(160, ErrorMessage = "Description: you must enter less than 160 characters")]
        [MinLength(40, ErrorMessage = "Description: you must enter more than 40 characters")]
        public string? Description { get; set; }

    }
}
