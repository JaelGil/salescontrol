using SalesControl.CreateClientRegistry.BusinessObject.Aggregate;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Repository
{
    public interface IClientRepository : IUnitOfWork
    {
        Task RegistryClient(AddressAggregate client);
    }
}
