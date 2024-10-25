using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.ViewModel.Layout
{
    public partial class MainLayout
    {

        public ErrorBoundary errorBoundaryRef { get; set; }

        public void Recover()
        {
            errorBoundaryRef?.Recover();
        }
    }
}
