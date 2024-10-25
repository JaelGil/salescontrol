using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using SalesControl.View;
using SalesControl.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesControl.View.AppPro;

namespace SalesControl.WindowsForms
{
    public partial class Mainform : Form
    {
        public Mainform(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            blazorWebView1.HostPage = "wwwroot/Index.html";
            blazorWebView1.Services = serviceProvider;
            blazorWebView1.RootComponents.Add<AppPro>("#App");
        }
    }
}