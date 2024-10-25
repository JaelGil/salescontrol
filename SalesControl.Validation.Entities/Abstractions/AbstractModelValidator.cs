using SalesControl.Validation.Entities.Enums;
using SalesControl.Validation.Entities.Interfaces;
using SalesControl.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validation.Entities.Abstractions
{
    public abstract class AbstractModelValidator<T>(
                         IValidationService<T> validationService,
                         ValidationConstrain constraint =
                         ValidationConstrain.AlwaysValidate
                         ) : IModelValidator<T>
    {
        public ValidationConstrain Constraint => constraint;
        public IEnumerable<ValidationError> Errors { get; private set; }
        public async Task<bool> Validate(T model)
        {
            Errors = await validationService.Validate(model);
            return Errors == default;
        }
        protected IValidationRules<T, TProperty> AddRuleFor<TProperty>(
        Expression<Func<T, TProperty>> expression) =>
        validationService.AddRuleFor<TProperty>(expression);
        protected ICollectionValidationRules<T, TProperty> AddRuleForEach<TProperty>(
        Expression<Func<T, IEnumerable<TProperty>>> expression) =>
        validationService.AddRuleForEach<TProperty>(expression);
        public IValidationService<T> ValidatorService => validationService;
    }
}
