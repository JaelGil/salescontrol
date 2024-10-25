using SalesControl.Entities.CreateClientRegistry.DTOs;
using SalesControl.Validators.Entities.CreateClientRegistry.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddModelValidator<CreateAddressRegistryDto,CreateAddressRegistryDtoValidator>();
        services.AddModelValidator<CreateClientRegistryDto,CreateClientRegistryDtoValidator>();
        return services;
    }
}