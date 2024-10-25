using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using SalesControl.DataContext.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesControl.DataContext.EntityFrameworkCore.Context;
using Microsoft.SharePoint.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SalesControl.View;
using SalesControl.ViewModel.Model;
using SalesControl.ViewModel.Component;
using SalesControl.CreateClientRegistry;
using SalesControl.Backend.IoC;
using SalesControl.DataContext.EntityFrameworkCore.Options;
using SalesControl.CreateClientRegistry.UsesCases;
using SalesControl.ViewModel;

namespace SalesControl.WindowsForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            // Inicializar la configuración
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsetting.json", optional: false, reloadOnChange: true)
                .Build();

            // Configurar los servicios
            var services = new ServiceCollection();

           

            // Registrar el servicio de Blazor
            services.AddWindowsFormsBlazorWebView();

            // Registrar el formulario principal
            services.AddTransient<Mainform>();
            services.AddPresentersService();
            services.AddUseCasesServices();
            services.AddModelService();
            // Configurar los servicios IoC

            services.AddDataBaseContexts(configuration);
            // Construir el contenedor de servicios
            var serviceProvider = services.BuildServiceProvider();
            
            // Iniciar la aplicación
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Obtener y ejecutar Mainform
            var mainForm = serviceProvider.GetRequiredService<Mainform>();
            Application.Run(mainForm);
           
        }
    }
}
