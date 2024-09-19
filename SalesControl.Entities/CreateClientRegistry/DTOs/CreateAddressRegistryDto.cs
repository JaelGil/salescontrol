using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Entities.CreateClientRegistry.DTOs
{
    public class CreateAddressRegistryDto(string street, string district, string departament, string province, string postalCode)
    {
        public string Street { get; } = street;
        public string District { get;} = district;
        public string Departament { get;} = departament;
        public string Province { get;} = province;
        public string PostalCode { get;} = postalCode;
        
    }
}
