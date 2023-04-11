using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Attributes
{
    public class MoreThanZeroPriceAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            int? price = (int?)value;
            if (price == null || price.ToString().Length == 0 )
            {
                return new ValidationResult("Il prezzo deve essere maggiore di 0");
            }
            return ValidationResult.Success;
        }
    }
}
