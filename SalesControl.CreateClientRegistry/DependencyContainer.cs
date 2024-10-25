using Microsoft.Extensions.DependencyInjection;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Controller;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Interface;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Repository;
using SalesControl.CreateClientRegistry.Controller;
using SalesControl.CreateClientRegistry.Presenter;
using SalesControl.CreateClientRegistry.Repository;
using SalesControl.CreateClientRegistry.UsesCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry
{

    public static class DependencyContainer
    {
        public static IServiceCollection AddPresentersService(this IServiceCollection services)
        {
            services.AddTransient<ICreateClientRegistryOutputPort, ClientPresenter>();
            services.AddTransient<IClientRepository, CreateClientRegistryCommandRepository>();
            services.AddTransient<IClientRegistryController, ClientController>();
            return services;
        }
    }
}