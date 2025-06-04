using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Hotel.Classes
{
    public static class ValidationService
    {
        public static List<ValidationResult> Validate<T>(T entity)
        {
            var context = new ValidationContext(entity);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(entity, context, results, validateAllProperties: true);
            return results;
        }

        public static bool IsValid<T>(T entity)
        {
            return Validate(entity).Count == 0;
        }
    }
}
