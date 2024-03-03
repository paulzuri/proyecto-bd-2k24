using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string District { get; set; }
        public City oCity { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string LastUpdate { get; set; }
    }
}
