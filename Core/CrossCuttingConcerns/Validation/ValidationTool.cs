using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation
{
    //tek bir instance ile her yerde kullanabilmek için
    public static class ValidationTool
    {
        // IValidator ile gelecek olan validator nesenlerenin ref ini tutan IValidtor eklendi
        // nesne olarak Dto, Entity bir sürü farklı şey validate edilebilir hepsinin atası olan object eklendi
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
