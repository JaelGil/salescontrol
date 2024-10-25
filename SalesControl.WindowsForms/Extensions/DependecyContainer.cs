using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SalesControl.Backend.IoC;
using SalesControl.DataContext.EntityFrameworkCore.Options;

namespace SalesControl.DataContext.EntityFrameworkCore;

public static class DependencyContainer
{
    public static IServiceCollection AddDataBaseContexts(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSalesServices(options =>
        {
            configuration.GetSection(BDOptions.SectionKey).Bind(options);
        });
        return services;
    }
}
