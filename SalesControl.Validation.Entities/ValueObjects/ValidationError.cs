using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validation.Entities.ValueObjects
{
    public class ValidationError(string propertyName, string message)
    {
        public string PropertyName => propertyName;
        public string Message => message;
    }
}
//Esta clase nos permitirá identificar un error de validación de alguna propiedad de un objeto validado.