using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.Entity
{
    public class Address
    {
        public int AddressId { get; set; }
        public int ClientId { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string Departament { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
    }
}
