using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Controller;
using SalesControl.Entities.CreateClientRegistry.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.ViewModel.Model
{
    //Modelos: van a contener los datos para las vistas.
    public class AddClientViewModel
    {
        private readonly IClientRegistryController _gateway;
        public AddClientViewModel(IClientRegistryController gateway)
        {
            _gateway = gateway; //puerta de entrada de los datos del frontend. desencadenar acciones para traer los datos.
        }
        public string DniClient { get; set; }
        public string NameClient { get; set; }
        public string SurnameClient { get; set; }
        public string PhoneClient { get; set; }
        public string EmailClient { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string Departament { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string InformationMessage { get; set; }

        public async Task Send()
        {
            var response = (CreateClientRegistryDto)this;
            await _gateway.AddClient(response);

        }

        public static explicit operator CreateClientRegistryDto(AddClientViewModel client)
        { //recibe un viewmodel y devuelve dto
            return new CreateClientRegistryDto(
                client.DniClient,
                client.NameClient,
                client.SurnameClient,
                client.PhoneClient,
                client.EmailClient,
                CreateAddressRegistryDto(client));
        }
        private static CreateAddressRegistryDto CreateAddressRegistryDto(AddClientViewModel client)
        {
            return new CreateAddressRegistryDto(
                client.Street,
                client.District,
                client.Departament,
                client.Province,
                client.PostalCode);
        }
        public async Task Save()
        {
            await _gateway.AddClient((CreateClientRegistryDto)this);
        }
        
    }
}
//primero @page = "ruta paara llegar pag", cuando es para editar lleva un form que empieza con editform
//luego hay una sentencia que dice a que metodo va a invocar elmodelo cuando preciono envir