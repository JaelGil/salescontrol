using Microsoft.Extensions.DependencyInjection.Extensions;
using SalesControl.Validation.Entities.Interfaces;
using SalesControl.Validation.Entities.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddDefaultModelValidatorHub(
    this IServiceCollection services)
    {
        services.TryAddScoped(typeof(IModelValidatorHub<>),
        typeof(ModelValidatorHub<>));
        return services;
    }
    public static IServiceCollection
    AddModelValidator<ModelType, ModelValidatorType>(
    this IServiceCollection services)
    where ModelValidatorType : class, IModelValidator<ModelType>
    {
        services.AddDefaultModelValidatorHub();
        services.AddScoped<IModelValidator<ModelType>, ModelValidatorType>();
        return services;
    }
}