using Microsoft.AspNetCore.Components;
using SalesControl.ViewModel.Model;

namespace SalesControl.ViewModel.Component
{
    public partial class RegistryClient
    {
        [Inject]
        public AddClientViewModel model {  get; set; }
    }
}
