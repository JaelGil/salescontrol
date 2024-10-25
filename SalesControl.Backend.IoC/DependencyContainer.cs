using Microsoft.Extensions.DependencyInjection;
using SalesControl.CreateClientRegistry;
using SalesControl.CreateClientRegistry.UsesCases;
using SalesControl.DataContext.EntityFrameworkCore;
using SalesControl.DataContext.EntityFrameworkCore.Options;
using SalesControl.ViewModel;

namespace SalesControl.Backend.IoC;
public static class DependencyContainer
{
    public static IServiceCollection AddSalesServices(this IServiceCollection services,
                                                      Action<BDOptions> configureDBOptions)
    {
        services.AddUseCasesServices()
                .AddPresentersService()
                .AddModelService()
                .AddDataContexts(configureDBOptions);
        return services;
    }
}
