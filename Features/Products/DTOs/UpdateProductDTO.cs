using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using WebApplication1.ValidationAttributes;

namespace WebApplication1.Features.Products.DTOs
{
    public class UpdateProductDTO
    { 
        [NotNullOrUndefined]
        [MinLength(20, ErrorMessage = "you must enter less than 20 characters")]
        [MaxLength(2, ErrorMessage = "you must enter more than 2 characters")]
        public string? Name { get; set; }

        [NotNullOrUndefinedAttribute]
        [MaxLength(40, ErrorMessage = "you must enter less than 160 characters")]
        [MinLength(160, ErrorMessage = "you must enter more than 40 characters")]
        public string? Description { get; set; }
    }
}
