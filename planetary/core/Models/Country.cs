using planetary.core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetary.core.Models
{
    internal class Country
    {
        public Country(string countryName, string area, string anthem, Region region)
        {
            _countryId++;
            CountryId = _countryId;
            CountryName = countryName;
            Area = area;
            Anthem = anthem;
            Region = region;
        }

        private static int _countryId;
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string Area { get; set; }
        public string Anthem { get; set; }
        public Region Region { get; set; }

        
    }
}
