using SalesControl.CreateClientRegistry.BusinessObject.Aggregate;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Interface;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Repository;
using SalesControl.CreateClientRegistry.BusinessObject.PocoEntities;
using SalesControl.Entities.CreateClientRegistry.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.UsesCases;

public class CreateClientRegistryInteractor(ICreateClientRegistryOutputPort presenter, IClientRepository repository) : ICreateClientRegistryInputPort
{
    public async Task Handle(CreateClientRegistryDto createClientRegistry)
    {
        var cliente = ToEntity(createClientRegistry);
        await repository.RegistryClient(cliente);
        await repository.SaveChanges();
        await presenter.Handle(cliente);
        

    }
    private static AddressAggregate ToEntity(CreateClientRegistryDto clientDto) 
    {
        return new AddressAggregate
        {
            DniClient = clientDto.DniClient,
            NameClient = clientDto.NameClient,
            SurnameClient = clientDto.SurnameClient,
            PhoneClient = clientDto.PhoneClient,
            EmailClient = clientDto.EmailClient,
            Street = clientDto.AddressClient.Street,
            District = clientDto.AddressClient.District,
            Departament = clientDto.AddressClient.Departament,
            Province = clientDto.AddressClient.Province,
            PostalCode = clientDto.AddressClient.PostalCode
        };
    }
}
    
    
