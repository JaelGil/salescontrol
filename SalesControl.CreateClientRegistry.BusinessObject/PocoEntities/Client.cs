using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesControl.CreateClientRegistry.BusinessObject.PocoEntities
{
    public class Client 
    {
        public int IdClient { get; set; }
        public string DniClient { get; set; }
        public string NameClient { get; set; }
        public string SurnameClient { get; set; }
        public string PhoneClient { get; set; }
        public string EmailClient {  get; set; }
        public bool Eliminado {  get; set; }
    }
}
