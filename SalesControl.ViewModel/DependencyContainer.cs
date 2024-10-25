using Microsoft.Extensions.DependencyInjection;
using SalesControl.ViewModel.Model;
using SalesControl.ViewModel.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.ViewModel;
public static class DependencyContainer
{
    public static IServiceCollection AddModelService(this IServiceCollection services)
    {
        services.AddTransient<AddClientViewModel>();
        
        return services;
    }
}
