using SalesControl.CreateClientRegistry.BusinessObject.Aggregate;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.CreateClientRegistry.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.Interface.Command
{
    internal interface IClientRegistryCommandDataContext
    {
        Task SaveClientAsync(Client client);
        Task SaveAddressAsync(Address address);
        Task SaveChangesAsync();
    }
}
