using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class EmployeeIdentifiers
    {
        public CustomEmployeeIdentifiers identifiers { get; set; }
    }
    public class CustomEmployeeIdentifiersData
    {
        public string barcode { get; set; }
        public string active_directory_username { get; set; }
        public string username { get; set; }
        public string passport_number { get; set; }
    }

    public class CustomEmployeeIdentifiers
    {
        public CustomEmployeeIdentifiersData data { get; set; }
    }
}
