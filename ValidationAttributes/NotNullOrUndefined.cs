namespace WebApplication1.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

public class NotNullOrUndefinedAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        return value != null && value.ToString() != "undefined";
    }
}
