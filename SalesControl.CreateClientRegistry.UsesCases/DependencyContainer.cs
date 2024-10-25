using Microsoft.Extensions.DependencyInjection;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.UsesCases;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
    {
        services.AddTransient<ICreateClientRegistryInputPort, CreateClientRegistryInteractor>();
        return services;
    }
}
