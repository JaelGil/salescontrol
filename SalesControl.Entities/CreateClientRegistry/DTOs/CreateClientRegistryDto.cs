using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Entities.CreateClientRegistry.DTOs
{
    public class CreateClientRegistryDto(
        string dniClient, 
        string nameClient,
        string surnameClient,
        string phoneClient, 
        string emailClient, 
        CreateAddressRegistryDto addressClient)
    {
        public string DniClient { get; } = dniClient;
        public string NameClient { get;} = nameClient;
        public string SurnameClient { get; } = surnameClient;
        public string PhoneClient { get;} = phoneClient;
        public string EmailClient { get; } = emailClient;
        public CreateAddressRegistryDto AddressClient { get;} = addressClient;

    }
}
