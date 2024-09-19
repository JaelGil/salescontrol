using SalesControl.CreateClientRegistry.BusinessObject.Aggregate;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Repository;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.CreateClientRegistry.Entity;
using SalesControl.CreateClientRegistry.Interface.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.Repository
{
    internal class CreateClientRegistryCommandRepository(IClientRegistryCommandDataContext context) : IClientRepository
    {
        public async Task RegistryClient(AddressAggregate client)
        {
            await context.SaveClientAsync(client);
            await context.SaveAddressAsync(new Address
            {
                Street = client.Street,
                District = client.District,
                Departament = client.Departament,
                Province = client.Province,
                PostalCode = client.PostalCode,
                ClientId = client.IdClient
            });
        }

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}
