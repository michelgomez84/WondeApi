using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class School
    {
        public string id { get; set; }
        public string name { get; set; }
        public object establishment_number { get; set; }
        public int urn { get; set; }
        public string phase_of_education { get; set; }
        public string la_code { get; set; }
        public string timezone { get; set; }
        public string mis { get; set; }
        public Address address { get; set; }
        public Extended extended { get; set; }
        public Region region { get; set; }


    }
}
