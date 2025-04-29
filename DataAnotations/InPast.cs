using System.ComponentModel.DataAnnotations;

namespace DesafioItau.DataAnotations
{
    public class InPast : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime date)
                return date < DateTimeOffset.Now;
            
            return true;
        }
    }
}