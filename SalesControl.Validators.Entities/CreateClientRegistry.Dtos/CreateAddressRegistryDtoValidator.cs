﻿using SalesControl.Entities.CreateClientRegistry.DTOs;
using SalesControl.Validation.Entities.Abstractions;
using SalesControl.Validation.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Validators.Entities.CreateClientRegistry.Dtos
{
    internal class CreateAddressRegistryDtoValidator :
    AbstractModelValidator<CreateAddressRegistryDto>
    {
        public CreateAddressRegistryDtoValidator(
        IValidationService<CreateAddressRegistryDto> validationService,
        IModelValidator<CreateAddressRegistryDto> detailValidator) :
        base(validationService)
        {
            //AddRuleFor(c => c.CustomerId)
            //.NotEmpty(CreateOrderMessages.CustomerIdRequired)
            //.Length(5, CreateOrderMessages.CustomerIdRequiredLength);
            //AddRuleFor(c => c.ShipAddress)
            //.NotEmpty(CreateOrderMessages.ShipAddressRequired)
            //.MaximumLength(60, CreateOrderMessages.ShipAddressMaximumLength);
            //AddRuleFor(c => c.ShipCity)
            //.NotEmpty(CreateOrderMessages.ShipCityRequired)
            //.MinimumLength(3, CreateOrderMessages.ShipCityMinimumLength)
            //.MaximumLength(15, CreateOrderMessages.ShipCityMaximumLength);
            //AddRuleFor(c => c.ShipCountry)
            //.NotEmpty(CreateOrderMessages.ShipCountryRequired)
            //.MinimumLength(3, CreateOrderMessages.ShipCountryMinimumLength)
            //.MaximumLength(15, CreateOrderMessages.ShipCountryMaximumLength);
            //AddRuleFor(c => c.ShipPostalCode)
            //.MaximumLength(10, CreateOrderMessages.ShipPostalCodeMaximumLength);
            //AddRuleFor(c => c.OrderDetails)
            //.NotNull(CreateOrderMessages.OrderDetailsRequired)
            //.NotEmpty(CreateOrderMessages.OrderDetailsNotEmpty);
            //AddRuleForEach(c => c.OrderDetails)
            //.SetValidator(detailValidator);
        }
    }
}
