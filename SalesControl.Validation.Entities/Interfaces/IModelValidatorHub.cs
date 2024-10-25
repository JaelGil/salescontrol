using SalesControl.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validation.Entities.Interfaces
{
    public interface IModelValidatorHub<T>
    {
        Task<bool> Validate(T model);
        IEnumerable<ValidationError> Errors { get; }
    }
}
//El servicio que hemos definido expondrá la misma funcionalidad que un validador, pero sin el
//requerimiento de validación. La implementación de este servicio permitirá ejecutar el código
//de validación de cada uno de los validadores registrados de un determinado modelo.