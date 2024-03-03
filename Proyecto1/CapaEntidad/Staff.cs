using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address oAddress { get; set; }
        public string Email { get; set; }
        public int StoreId { get; set; }
        public bool Active { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LastUpdate { get; set; }
        public byte[] Picture { get; set; }
    }
}