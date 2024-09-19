using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.Entities.CreateClientRegistry.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Interface
{
    public interface ICreateClientRegistryOutputPort
    {
        public int Id { get; }
        Task Handle(Client createClient);
    }
}
