using SalesControl.Validation.Entities.Enums;
using SalesControl.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validation.Entities.Interfaces
{
    public interface IModelValidator<T>
    {
        ValidationConstrain Constraint { get; }
        IEnumerable<ValidationError> Errors { get; }
        Task<bool> Validate(T model);
    }
}
//validación. Una clase que valide un modelo ofrecerá un método Validate que reciba el modelo
//a validar y devolverá el valor true en caso de que no haya errores de validación. Si el valor
//devuelto no es true, la colección Errors tendrá la información sobre los errores encontrados
//en cada propiedad del modelo. La propiedad Constraint permitirá indicar si la validación debe
//o no ejecutarse cuando haya errores previos de validación en algún otro validador previo del
//mismo modelo. Esto puede ser útil en el caso de tener un validador que valide los datos de entrada
//y otro que valide los datos de entrada contra valores de una base de datos.
//En caso de que los datos de entrada sean incorrectos, no tiene sentido validar contra la base de datos.