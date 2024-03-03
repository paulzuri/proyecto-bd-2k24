using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Country oCountry { get; set; }
        public string LastUpdate { get; set; }
    }
}
