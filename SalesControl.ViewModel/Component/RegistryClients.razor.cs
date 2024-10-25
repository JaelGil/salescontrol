using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using SalesControl.ViewModel.Model;

namespace SalesControl.ViewModel.Component
{
    public partial class RegistryClients
    {
        [Inject]
        public AddClientViewModel model { get; set; }
    }
}
