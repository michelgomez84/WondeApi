using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Address
    {
        public string address_line_1 { get; set; }
        public string address_line_2 { get; set; }
        public string address_town { get; set; }
        public string address_postcode { get; set; }
        public AddressCountry address_country { get; set; }
    }
}
