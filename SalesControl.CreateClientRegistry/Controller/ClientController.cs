using Microsoft.Graph.Models;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Controller;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Interface;
using SalesControl.Entities.CreateClientRegistry.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.Controller
{
    public class ClientController(ICreateClientRegistryInputPort inputPort,
                                    ICreateClientRegistryOutputPort presenter) : IClientRegistryController
    {

        public async Task<int> AddClient(CreateClientRegistryDto createClientRegistry)
        {
            
            await inputPort.Handle(createClientRegistry);
            return presenter.Id;
        }
    }
}
