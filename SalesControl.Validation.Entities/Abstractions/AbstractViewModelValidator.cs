using SalesControl.Validation.Entities.Enums;
using SalesControl.Validation.Entities.Interfaces;
using SalesControl.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validation.Entities.Abstractions
{
    public abstract class AbstractViewModelValidator<DtoType, ViewModelType>(
    IModelValidatorHub<DtoType> dtoModelValidatorHub,
    ValidationConstrain constraint) : IModelValidator<ViewModelType>
    {
        public ValidationConstrain Constraint => constraint;
        public IEnumerable<ValidationError> Errors =>
        dtoModelValidatorHub.Errors;
        // En caso de que el ViewModel implemente el operador Explicit se puede
        // utilizar este método.
        // Si el ViewModel no implementa el operador Explicit, se podrá remplazar
        // (Override) este método en la clase que implemente esta clase.
        public virtual DtoType Cast(ViewModelType viewModel)
        {
            DtoType DtoModel = default;
            var ExplicitMethod = typeof(ViewModelType).GetMethod("op_Explicit");
            if (ExplicitMethod != null)
                DtoModel = (DtoType)ExplicitMethod.Invoke(viewModel, new object[] { viewModel });
            else
                throw new InvalidCastException();
            return DtoModel;
        }
        public Task<bool> Validate(ViewModelType model) =>
        dtoModelValidatorHub.Validate(Cast(model));
    }
}
