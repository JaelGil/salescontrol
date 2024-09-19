using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Interface;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.Entities.CreateClientRegistry.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.Presenter
{
    public class ClientPresenter : ICreateClientRegistryOutputPort
    {
        public int Id { get; private set; }
        public Task Handle(Client createClient)
        {
            Id = createClient.IdClient;
            return Task.CompletedTask;
        }
    }
}
