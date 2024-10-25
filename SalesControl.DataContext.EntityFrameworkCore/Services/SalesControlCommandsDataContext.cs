using Microsoft.Extensions.Options;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.CreateClientRegistry.Entity;
using SalesControl.CreateClientRegistry.Interface.Command;
using SalesControl.DataContext.EntityFrameworkCore.Context;
using SalesControl.DataContext.EntityFrameworkCore.Options;

namespace SalesControl.DataContext.EntityFrameworkCore.Services
{
    internal class SalesControlCommandsDataContext(IOptions<BDOptions> bdOptions) : SalesControlContextProduction(bdOptions),
                                                                                    IClientRegistryCommandDataContext
    {
        public async Task SaveClientAsync(Client client)
        {
            await AddAsync(client);
        }
        public async Task SaveAddressAsync(Address address)
        {
            await AddAsync(address);
        }
        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}