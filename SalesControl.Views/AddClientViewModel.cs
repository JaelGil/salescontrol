using SalesControl.CreateClientRegistry.BusinessObject.Aggregate;
using SalesControl.CreateClientRegistry.BusinessObject.Interfaces.ClientInterface.Controller;
using SalesControl.Entities.CreateClientRegistry.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.Views
{
    //Modelos: van a contener los datos para las vistas.
    public class AddClientViewModel /*: INotifyPropertyChanged, IDataErrorInfo*/
    {
        private readonly IClientRegistryController _gateway;
        public AddClientViewModel(IClientRegistryController gateway)
        {
            _gateway = gateway; //puerta de entrada de los datos del frontend. desencadenar acciones para traer los datos.
        }

        string _dniClient;
        public string DniClient
        {
            get => _dniClient;
            set => _dniClient = value;
        }
        string _nameClient;
        public string NameClient
        {
            get => _nameClient;
            set => _nameClient = value;
        }
        string _surnameClient;
        public string SurnameClient
        {
            get => _surnameClient;
            set => _surnameClient = value;
        }
        string _phoneClient;
        public string PhoneClient
        {
            get => _phoneClient;
            set => _phoneClient = value;
        }
        string _emailClient;
        public string EmailClient
        {
            get => _emailClient;
            set => _emailClient = value;
        }
        string _street;
        public string Street
        {
            get => _street;
            set => _street = value;
        }
        string _district;
        public string District
        {
            get => _district;
            set => _district = value;
        }
        string _departament;
        public string Departament
        {
            get => _departament;
            set => _departament = value;
        }
        string _province;
        public string Province
        {
            get => _province;
            set => _province = value;
        }
        string _postalCode;
        public string PostalCode
        {
            get => _postalCode;
            set => _postalCode = value;
        }
        string _informationMessage;

        public string InformationMessage
        {
            get => _informationMessage;
            private set => _informationMessage = value;
        }
       
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
    }
}