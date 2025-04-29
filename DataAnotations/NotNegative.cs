using System.ComponentModel.DataAnnotations;

namespace DesafioItau.DataAnotations
{
    public class NotNegative : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is decimal amount)
                return amount >= 0;

            return true;
        }
    }
}