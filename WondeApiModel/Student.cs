using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondeApiModel
{
    public class Student
    {
        public string id { get; set; }
        public string upi { get; set; }
        public string mis_id { get; set; }
        public string initials { get; set; }
        public string surname { get; set; }
        public string forename { get; set; }
        public string middle_names { get; set; }
        public string legal_surname { get; set; }
        public string legal_forename { get; set; }
        public string gender { get; set; }
        public CustomDate date_of_birth { get; set; }
        public CustomDate restored_at { get; set; }
        public CustomDate created_at { get; set; }
        public CustomDate updated_at { get; set; }

       

    }

}
