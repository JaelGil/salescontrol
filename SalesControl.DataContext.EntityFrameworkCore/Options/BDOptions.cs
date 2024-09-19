using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.DataContext.EntityFrameworkCore.Options
{
    public class BDOptions
    {
        public const string SectionKey = nameof(BDOptions);
        public string ConnectionString { get; set; }
    }
}
