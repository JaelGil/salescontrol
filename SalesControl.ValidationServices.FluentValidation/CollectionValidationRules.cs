//using FluentValidation;
//using SalesControl.Validation.Entities.Abstractions;
//using SalesControl.Validation.Entities.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SalesControl.ValidationServices.FluentValidation
//{
//    internal class CollectionValidationRules<T, TProperty>(
//    IRuleBuilderInitialCollection<T, TProperty> ruleBuilderInitialCollection) :
//    ICollectionValidationRules<T, TProperty>
//    {
//        public ICollectionValidationRules<T, TProperty> SetValidator(
//        IModelValidator<TProperty> modelValidator)
//        {
//            var ModelValidator =
//            modelValidator as AbstractModelValidator<TProperty>;
//            var ValidationService =
//            ModelValidator.ValidatorService as
//            FluentValidationService<TProperty>;
//            ruleBuilderInitialCollection
//            .SetValidator(ValidationService.Wrapper);
//            return this;
//        }
//    }
//}
