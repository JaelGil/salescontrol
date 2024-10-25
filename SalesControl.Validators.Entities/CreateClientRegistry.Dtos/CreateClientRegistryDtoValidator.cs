using SalesControl.Entities.CreateClientRegistry.DTOs;
using SalesControl.Validation.Entities.Abstractions;
using SalesControl.Validation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validators.Entities.CreateClientRegistry.Dtos
{
    internal class CreateClientRegistryDtoValidator : AbstractModelValidator<CreateClientRegistryDto>
    {
        public CreateClientRegistryDtoValidator(
        IValidationService<CreateClientRegistryDto> validator) : base(validator)
        {
            //AddRuleFor(d => d.ProductId)
            //.GreaterThan(0, CreateOrderMessages.ProductIdGreaterThanZero);
            //AddRuleFor<int>(d => d.Quantity)
            //.GreaterThan(0, CreateOrderMessages.QuantityGreaterThanZero);
            //AddRuleFor(d => d.UnitPrice)
            //.GreaterThan<decimal>(0,
            //CreateOrderMessages.UnitPriceGreaterThanZero);
        }
    }
}
