using Microsoft.Extensions.DependencyInjection;
using SalesControl.CreateClientRegistry.Interface.Command;
using SalesControl.DataContext.EntityFrameworkCore.Context;
using SalesControl.DataContext.EntityFrameworkCore.Options;
using SalesControl.DataContext.EntityFrameworkCore.Services;

namespace SalesControl.DataContext.EntityFrameworkCore;

public static class DependencyContainer
{
    public static IServiceCollection AddDataContexts(this IServiceCollection services,
                                                        Action<BDOptions> configureBDOptions)
    {
        services.Configure(configureBDOptions);
        services.AddTransient<IClientRegistryCommandDataContext, SalesControlCommandsDataContext>();
        services.AddTransient<SalesControlContextProduction, SalesControlCommandsDataContext>();
        return services;
    }
}
//AddScoped: cuando quieres que un servicio comparta información a lo largo de una solicitud específica,
//pero no entre diferentes solicitudes. (web api) - otro contenedor de dependencia. 