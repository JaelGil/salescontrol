using SalesControl.Entities.CreateClientRegistry.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Interface
{
    public interface ICreateClientRegistryInputPort
    {
        Task Handle(CreateClientRegistryDto createClientRegistry);
    }
}
